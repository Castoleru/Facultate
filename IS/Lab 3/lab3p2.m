close all
%grad 2, raspuns impuls.
t=scope130(:,1);
u=scope130(:,2);
h=scope130(:,4);
t=t-t(1); %muta t initial in 0;

plot(t,[u,h])

i1=414;
i2=464;

hst=mean(h(i1:i2));
ust=mean(u(i1:i2));
k=hst/ust;

%pentru constanta T1
i3=100;
i4=220;
t_log=t(i3:i4);
h_log=h(i3:i4);
plot(t,h);hold on
plot(t(i3:i4),h(i3:i4),'r');
a=[sum(t_log.^2) sum(t_log); sum(t_log) length(t_log)];
b=[sum(t_log.*log(h_log-hst)); sum(log(h_log-hst))];
sol=a\b; %impartire la stanga
T1=-1/sol(1);

%pentru constanta T2
i5=180;
i6=200;
t_log2=t(i5:i6);
h_log2=h(i5:i6)-k*exp(-t_log2/T1);
plot(t,h);hold on
plot(t_log2,h_log2,'r');
a=[sum(t_log2.^2) sum(t_log2); sum(t_log2) length(t_log2)];
b=[sum(t_log2.*log(h_log2-hst)); sum(log(h_log2-hst))];
sol=a\b; %impartire la stanga
T2=-1/sol(1);

A=[0 1;-1/(T1*T2) -(T1+T2)/(T1*T2)];
B=[0; k/(T1*T2)]; C=[1 0]; D=[0];
hold on
hsim=lsim(A,B,C,D,u,t,[h(1) 0]);
plot(t,[u h hsim])
eMPN=norm(h-hsim)/norm(h-mean(h))

%plot de hsim depinde de spatiul starilor (A,B,C,D)
%ss depinde de factorul de proportionalitate
%factorul de proportionalitate se calculeaza din hst/ust




