close all

t=double(dat_0p7.X.Data)'; %ia campul x, .data si datele numerice si facem matrice coloana
d=double(dat_0p7.Y(1,3).Data)'; %semnal de comanda
w=double(dat_0p7.Y(1,2).Data)'; %viteza
theta=double(dat_0p7.Y(1,1).Data)'; %pozitia
figure
subplot(311); plot(t,d);
subplot(312); plot(t,w); %viteza unghiulara
subplot(313); plot(t,theta); %pozitia unghiulara

Te=t(2)-t(1);
%interpolare viteza:
wi=w;
i1=3706; i2=5612; i3=8534; i4=10496;
wi(i1:i2)=interp1([t(i1) t(i2)],[wi(i1) wi(i2)],t(i1:i2)); %x start-xend, ystart-yend,x
wi(i3:i4)=interp1([t(i3) t(i4)],[wi(i3) wi(i4)],t(i3:i4)); %x start-xend, ystart-yend,x
w=wi;
figure
subplot(311); plot(t,d);
subplot(312); plot(t,w); %viteza unghiulara
subplot(313); plot(t,theta); %pozitia unghiulara

t1=684; t2=3706; t3=5612; t4=8539;

data_id_w=iddata(w(t1:t2),d(t1:t2),Te); %date identificare la viteza
data_id_theta=iddata(theta(t1:t2),w(t1:t2),Te); %date identificare poz

data_v_w=iddata(w(t3:t4),d(t3:t4),Te); %date validare la viteza
data_v_theta=iddata(theta(t3:t4),w(t3:t4),Te); %date identificare poz

data_g_w=iddata(w,d,Te); %date generale la viteza
data_g_theta=iddata(theta,w,Te); %date generale theta

%% ARX
m_arx_w=arx(data_id_w,[1 1 1]); %modelul arx pt w, ordin 1 => [1 1 1]. 
    %Partea electrica neglijabila in functie cu cea mecanica, de aia ramane ordin 1, [2 2 1] pt ordin 2
Hd_w_d_arx=tf(m_arx_w.B,m_arx_w.A,Te,'variable','z^-1'); %fdt de la d la w, intai iesire dupa intrare

m_arx_theta=arx(data_id_theta,[1 1 1]);
Hd_theta_w_arx=tf(m_arx_theta.B,m_arx_theta.A,Te,'variable','z^-1');

figure
resid(m_arx_w,data_v_w,'corr',5); %pe baza de corelatie
compare(m_arx_w,data_g_w)
figure
resid(m_arx_theta,data_v_theta,'corr',5); %pe baza de corelatie
compare(m_arx_theta,data_g_theta)

%% ARMAX
m_armax_w=armax(data_id_w, [1 1 1 1]);
Hd_w_d_armax=tf(m_armax_w.B,m_armax_w.A,Te,'variable','z^-1');
m_armax_theta=armax(data_id_theta, [1 1 1 1]); %ultimul 1 e nD
Hd_w_theta_armax=tf(m_armax_theta.B,m_armax_theta.A,Te,'variable','z^-1')

figure
resid(m_armax_w,data_v_w,'corr',5); %pe baza de corelatie
compare(m_armax_w,data_g_w)
figure
resid(m_armax_theta,data_v_theta,'corr',5); %pe baza de corelatie
compare(m_armax_theta,data_g_theta)
%se poate valida doar modelul de la intrare la pozitie dupa autocorelatie

%%
H_w_d_c=d2c(Hd_w_d_arx,'zoh'); %fdt in continuu


H_w_d_c=d2c(Hd_w_d_armax,'zoh'); %fdt in continuu

%% Lab9->continuare, metoda IV
m_iv_w=iv4(data_id_w,[1 1 1]); %modelul identificat prin IV la viteza,[na nb nd]
Hd_w_d_iv=tf(m_iv_w.B,m_iv_w.A,Te,'variable','z^-1');
figure
resid(m_iv_w,data_v_w,'corr',5);
compare(m_iv_w,data_g_w);

m_iv_theta=iv4(data_id_theta,[1 1 1]); %modelul identificat prin IV la pozitie,[na nb nd]
Hd_theta_w_iv=tf(m_iv_theta.B,m_iv_theta.A,Te,'variable','z^-1');
figure
resid(m_iv_theta,data_v_theta,'corr',5);
compare(m_iv_theta,data_g_theta);

%% Metoda OE
m_oe_w=oe(data_id_w,[1 1 1]); %nF nB nd
Hd_wd_oe=tf(m_oe_w.B,m_oe_w.F,Te,'variable','z^-1');
figure
resid(m_oe_w,data_v_w,'corr',5);
compare(m_oe_w,data_g_w);

m_oe_theta=oe(data_id_theta,[1 1 1]); %nF nB nd
Hd_thetaw_oe=tf(m_oe_theta.B,m_oe_theta.F,Te,'variable','z^-1');
figure
resid(m_oe_theta,data_v_theta,'corr',5);
compare(m_oe_theta,data_g_theta);

%%
H_w_d_iv=d2c(Hd_w_d_iv,'zoh');
H_w_d_oe=d2c(Hd_wd_oe,'zoh');

Ki=0.001769/Te; %0.001769 luat coeficientul de la num din Hd_thetaw_oe;
H_theta_w=tf(Ki,[1 0]);

%%
Hd_w_d_armax=tf(m_armax_w.B,m_armax_w.A,Te,'variable','z^-1');
Hd1=d2c(Hd_w_d_armax);
Ki=0.001769/Te; %0.001769 luat coeficientul de la num din Hd_thetaw_oe;
H_theta_w=tf(Ki,[1 0]);
Hf=H_theta_w*Hd1;