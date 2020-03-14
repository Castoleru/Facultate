close all
t=double(dat_0p7.X.Data)';
d=double(dat_0p7.Y(1,3).Data)';%semnal de comanda ce preciseaza sensul
w=double(dat_0p7.Y(1,2).Data)';%viteza unghiulara
theta=double(dat_0p7.Y(1,1).Data)';%pozitia unghiulara

figure
subplot(3,1,1);plot(t,d);
subplot(3,1,2);plot(t,w);
subplot(3,1,3);plot(t,theta);

Te=t(2)-t(1);
i1=3706;
i2=5538;
i3=8540;
i4=10492;
wi=w;
wi(i1:i2)=interp1([t(i1) t(i2)],[wi(i1) wi(i2)],t(i1:i2));
wi(i3:i4)=interp1([t(i3) t(i4)],[wi(i3) wi(i4)],t(i3:i4));
w=wi;

figure
subplot(3,1,1);plot(t,d);
subplot(3,1,2);plot(t,w);
subplot(3,1,3);plot(t,theta);

t1=654;
t2=3753;
t3=5621;
t4=8461;
data_id_w=iddata(w(t1:t2),d(t1:t2),Te);%date identificare
data_id_th=iddata(theta(t1:t2),w(t1:t2),Te);
data_v_w=iddata(w(t3:t4),d(t3:t4),Te);%date validare
data_v_th=iddata(theta(t3:t4),w(t3:t4),Te);
data_g_w=iddata(w,d,Te);%date generale
data_g_th=iddata(theta,w,Te);

%% ARX

model_arx_w=arx(data_id_w,[1 1 1]);
Hd_w_d_arx=tf(model_arx_w.B,model_arx_w.A,Te,'variable','z^-1');%functia de transfer de la intrare d cu iesire w
model_arx_th=arx(data_id_th,[1 1 1]);
Hd_th_w_arx=tf(model_arx_th.B,model_arx_th.A,Te,'variable','z^-1');%functia de transfer de la intrare w cu iesire th

figure
resid(model_arx_w,data_v_w,'corr',5);
figure
compare(model_arx_w,data_g_w)
figure
resid(model_arx_th,data_v_th,'corr',5);
figure
compare(model_arx_th,data_g_th)
%% ARMAX
model_armax_w=armax(data_id_w,[1 1 1 1]);
Hd_w_d_armax=tf(model_armax_w.B,model_armax_w.A,Te,'variable','z^-1');%functia de transfer de la intrare d cu iesire w

figure
resid(model_armax_w,data_v_w,'corr',5);
figure
compare(model_armax_w,data_g_w)

model_armax_th=armax(data_id_th,[1 1 1 1]);
Hd_th_w_armax=tf(model_armax_th.B,model_armax_th.A,Te,'variable','z^-1');%functia de transfer de la intrare d cu iesire w

figure
resid(model_armax_th,data_v_th,'corr',5);
figure
compare(model_armax_th,data_g_th)

H_w_d_arx=d2c(Hd_w_d_arx,'zoh')
H_w_d_armax=d2c(Hd_w_d_armax,'zoh')


H_th_w_arx=d2c(Hd_th_w_arx,'zoh')
H_th_w_armax=d2c(Hd_th_w_armax,'zoh')
%% IV4
m_iv_w=iv4(data_id_w,[1 1 1]);
Hd_w_d_iv=tf(m_iv_w.B,m_iv_w.A,Te,'variable','z^-1');
figure
resid(m_iv_w,data_v_w,'corr',5);
figure
compare(m_iv_w,data_g_w)


model_iv_th=iv4(data_id_th,[1 1 1]);
Hd_th_w_iv=tf(model_iv_th.B,model_iv_th.A,Te,'variable','z^-1');%functia de transfer de la intrare d cu iesire w

figure
resid(model_iv_th,data_v_th,'corr',5);
figure
compare(model_iv_th,data_g_th)

%% OE
m_oe_w=oe(data_id_w,[1 1 1]);
Hd_w_d_oe=tf(m_oe_w.B,m_oe_w.F,Te,'variable','z^-1');
figure
resid(m_oe_w,data_v_w,'corr',5);
figure
compare(m_oe_w,data_g_w)

model_oe_th=oe(data_id_th,[1 1 1]);
Hd_th_w_oe=tf(model_oe_th.B,model_oe_th.F,Te,'variable','z^-1');%functia de transfer de la intrare d cu iesire w

figure
resid(model_oe_th,data_v_th,'corr',5);
figure
compare(model_oe_th,data_g_th)
%% Modele continue
H_w_d_iv=d2c(Hd_w_d_iv,'zoh')
H_th_w_iv=tf([3.85],[1 0])

H_w_d_oe=d2c(Hd_w_d_oe,'zoh')
H_th_w_oe=tf([3.93],[1 0])

%% Ex 1------------------------------------------- Proiect in caz de nu obt un model valid
m_arx_w_pem=pem(data_id_w,model_arx_w);
figure
resid(m_arx_w_pem,data_v_w,'corr',5);
figure
compare(m_arx_w_pem,data_g_w)

m_arx_th_pem=pem(data_id_th,model_arx_th);
figure
resid(m_arx_th_pem,data_v_th,'corr',5);
figure
compare(m_arx_th_pem,data_g_th)
%% ex 2
m_oe_w_pem=pem(data_id_w,m_oe_w);
figure
resid(m_oe_w_pem,data_v_w,'corr',5);
figure
compare(m_oe_w_pem,data_g_w)

m_oe_th_pem=pem(data_id_th,model_oe_th);
figure
resid(m_oe_th_pem,data_v_th,'corr',5);
figure
compare(m_oe_th_pem,data_g_th)
%% Ex3 
i7=6682;
i8=6698;
N=i8-i7+1;
t_dec=t(1:N:end);
d_dec=d(1:N:end);
w_dec=w(1:N:end);
th_dec=theta(1:N:end);
plot(t_dec,w_dec);
Te_dec=Te*N;
t1d=round(t1/N);
t2d=round(t2/N);
t3d=round(t3/N);
t4d=round(t4/N);

data_id_w_dec=iddata(w_dec(t1d:t2d),d_dec(t1d:t2d),Te_dec);%date identificare
data_id_th_dec=iddata(th_dec(t1d:t2d),w_dec(t1d:t2d),Te_dec);
data_v_w_dec=iddata(w_dec(t3d:t4d),d_dec(t3d:t4d),Te_dec);%date validare
data_v_th_dec=iddata(th_dec(t3d:t4d),w_dec(t3d:t4d),Te_dec);
data_g_w_dec=iddata(w_dec,d_dec,Te_dec);%date generale
data_g_th_dec=iddata(th_dec,w_dec,Te_dec);
%% Ex3 Arx 
model_arx_w_dec=arx(data_id_w_dec,[1 1 1]);
Hd_w_d_arx_dec=tf(model_arx_w_dec.B,model_arx_w_dec.A,Te,'variable','z^-1');%functia de transfer de la intrare d cu iesire w
model_arx_th_dec=arx(data_id_th_dec,[1 1 1]);
Hd_th_w_arx=tf(model_arx_th_dec.B,model_arx_th_dec.A,Te,'variable','z^-1');%functia de transfer de la intrare w cu iesire th

figure
resid(model_arx_w_dec,data_v_w_dec,'corr',5);
figure
compare(model_arx_w_dec,data_g_w_dec)
figure
resid(model_arx_th_dec,data_v_th_dec,'corr',5);
figure
compare(model_arx_th_dec,data_g_th_dec)

m_arx_w_pem_dec=pem(data_id_w_dec,model_arx_w_dec);
figure
resid(m_arx_w_pem_dec,data_v_w_dec,'corr',5);
figure
compare(m_arx_w_pem_dec,data_g_w_dec)

m_arx_th_pem_dec=pem(data_id_th_dec,model_arx_th_dec);
figure
resid(m_arx_th_pem_dec,data_v_th_dec,'corr',5);
figure
compare(m_arx_th_pem_dec,data_g_th_dec)
%% Ex4 OE
m_oe_w_dec=oe(data_id_w_dec,[1 1 1]);
Hd_w_d_oe_dec=tf(m_oe_w_dec.B,m_oe_w_dec.F,Te,'variable','z^-1');
figure
resid(m_oe_w_dec,data_v_w_dec,'corr',5);
figure
compare(m_oe_w_dec,data_g_w_dec)

model_oe_th_dec=oe(data_id_th_dec,[1 1 1]);
Hd_th_w_oe=tf(model_oe_th_dec.B,model_oe_th_dec.F,Te,'variable','z^-1');%functia de transfer de la intrare d cu iesire w

figure
resid(model_oe_th_dec,data_v_th_dec,'corr',5);
figure
compare(model_oe_th_dec,data_g_th_dec)

m_oe_w_dec_pem_dec=pem(data_id_w_dec,m_oe_w_dec);
figure
resid(m_oe_w_dec_pem_dec,data_v_w_dec,'corr',5);
figure
compare(m_oe_w_dec_pem_dec,data_g_w_dec)

m_oe_th_pem_dec=pem(data_id_th_dec,model_oe_th_dec);
figure
resid(m_oe_th_pem_dec,data_v_th_dec,'corr',5);
figure
compare(m_oe_th_pem_dec,data_g_th_dec);
%% EX 5
data_id=iddata([theta(t1:t2),w(t1:t2)],d(t1:t2),Te);
data_v=iddata([theta(t3:t4),w(t3:t4)],d(t3:t4),Te);
data_g=iddata([theta,w],d,Te);
M_pem=pem(data_id);

figure
resid(M_pem,data_v,'corr',5);
figure
compare(M_pem,data_g);

%% Ex 6
data_dw_id=iddata(theta(t1:t2),d(t1:t2),Te);
data_dw_v=iddata(theta(t3:t4),d(t3:t4),Te);
data_dw_g=iddata(theta,d,Te);
m_oe_dw=oe(data_dw_id,[2 2 1]);
Hd_dw_oe=tf(m_oe_dw.B,m_oe_dw.F,Te,'variable','z^-1');
Hd_dw=d2c(Hd_dw_oe,'zoh');

figure
resid(m_oe_dw,data_dw_v,'corr',5);
figure
compare(m_oe_dw,data_dw_g);

m_oe_dw_pem=pem(data_dw_id,m_oe_dw);
figure
resid(m_oe_dw_pem,data_dw_v,'corr',5);
figure
compare(m_oe_dw_pem,data_dw_g);
%% Ex1- lab 12
%pentru w
ssest(data_id_w, 1:10);
nx_w=1;
%pentru th
ssest(data_id_th, 1:10);
nx_th=1;
%% Ex2- lab 12
model_n4_w=n4sid(data_id_w,nx_w);
figure
resid(model_n4_w,data_v_w,'corr',5);
figure
compare(model_n4_w,data_g_w)

model_n4_th=n4sid(data_id_th,nx_th);
figure
resid(model_n4_th,data_v_th,'corr',5);
figure
compare(model_n4_th,data_g_th)

model_ss_w=ssest(data_id_w,nx_w);
figure
resid(model_ss_w,data_v_w,'corr',5);
figure
compare(model_ss_w,data_g_w)

model_ss_th=ssest(data_id_th,nx_th);
figure
resid(model_ss_th,data_v_th,'corr',5);
figure
compare(model_ss_th,data_g_th)
%% Ex3- lab 12
%pentru w
ssest(data_id_w_dec, 1:10);
nx_w_dec=1;
%pentru th
ssest(data_id_th_dec, 1:10);
nx_th_dec=1;

model_n4_w_dec=n4sid(data_id_w_dec,nx_w_dec);
figure
resid(model_n4_w_dec,data_v_w_dec,'corr',5);
figure
compare(model_n4_w_dec,data_g_w_dec)

model_n4_th_dec=n4sid(data_id_th_dec,nx_th_dec);
figure
resid(model_n4_th_dec,data_v_th_dec,'corr',5);
figure
compare(model_n4_th_dec,data_g_th_dec)

model_ss_w_dec=ssest(data_id_w_dec,nx_w_dec);
figure
resid(model_ss_w_dec,data_v_w_dec,'corr',5);
figure
compare(model_ss_w_dec,data_g_w_dec)

model_ss_th_dec=ssest(data_id_th_dec,nx_th_dec);
figure
resid(model_ss_th_dec,data_v_th_dec,'corr',5);
figure
compare(model_ss_th_dec,data_g_th_dec)

%% Ex 4- lab 12
ssest(data_id, 1:10);
nx=2;

model_n4=n4sid(data_id,nx);
figure
resid(model_n4,data_v,'corr',5);
figure
compare(model_n4,data_g)

model_ss=ssest(data_id,nx);
figure
resid(model_ss,data_v,'corr',5);
figure
compare(model_ss,data_g)
%% Ex 5- ex
H_ss_w=tf(model_ss_w_dec);
[num, den]=ss2tf(model_ss_th_dec.A,model_ss_th_dec.B,model_ss_th_dec.C,model_ss_th_dec.D);
H_ss_th=tf(num,[1 0]);
H_fin_ss=series(H_ss_w,H_ss_th)

