t=scope130(:,1);
u=scope130(:,2);
y=scope130(:,3);

%       FILTRU MEDIAN
% u_filtru=zeros(length(u),1);
% ord=3;
% N1=floor(ord/2);
% u_filtru(1+N1:length(u)-N1)=median_filt(u,ord);
% for i=1:N1
%     u_filtru(1)=u_filtru(N1+1);
%     u_filtru(length(u)-i+1)=u_filtru(length(u)-N1);
% end
% 
% plot(t,u_filtru)
% 
%       TUKEY
% u=tukey53H(u);
%
%       FILTRU LULU
u_L=LU_op(u,3,'L');
u_LV=LU_op(u_L,3,'U');
plot(t,[u u_LV])
u_mf=median_filter(u,2);
figure;
plot(t,[u u_mf])
u_tu=tukey53H(u);
figure;plot(t,[u u_tu])



%SGOLAY-> oreder=ordinul curbei, framelen=ordinul filtrului

figure
plot(t,[u,y])
title('Raspuns la impuls')
xlabel('t[s]')
ylabel('u[V] y[V]')
legend('Intrare','Raspuns sistem')

i1=411; i2=493;
yst=mean(y(i1:i2));
ust=mean(u(i1:i2));
k=yst/ust;

i3=39; i4=195; i5=302;
sigma=sum(abs(y(i4:i5)-yst))/sum(y(i3:i4)-yst); %aprox 18%
zeta=-log(sigma)/sqrt(pi^2+(log(sigma)^2)); %aprox 0.5

i6=84; i7=242;
wosc=pi/(t(i7)-t(i6));
wn=pi/((t(i7)-t(i6))*sqrt(1-zeta^2));

H=tf([k*wn^2],[1 2*zeta*wn wn^2]);
A=[0 1;-wn^2 -2*zeta*wn]; B=[0; k*wn^2]; C=[1 0]; D=[0];
ysim=lsim(A,B,C,D,u,t,[y(1),0]);
figure
plot(t,[u,y])
hold on
plot(t,ysim,'g')
title('Raspuns la treapta')
xlabel('t[s]')
ylabel('u[V] y[V]')
legend('Intrare','Raspuns Sistem','Simulare CI!=0')

eMPN=norm(y-ysim)/norm(y-mean(y))


