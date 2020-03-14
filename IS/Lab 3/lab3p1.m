close all

%grad 1 raspuns impuls
t=scope130(:,1);
u=scope130(:,2);
h=scope130(:,3);
t=t-t(1); %muta t initial in 0;

plot(t,[u,h])

i1=331;
i2=481;

hst=mean(h(i1:i2));
ust=mean(u(i1:i2));
k=hst/ust;

i3=64;
i4=147;
t_log=t(i3:i4);
h_log=h(i3:i4);
% plot(t,h);hold on
% plot(t(i3:i4),h(i3:i4),'r');
a=[sum(t_log.^2) sum(t_log); sum(t_log) length(t_log)];
b=[sum(t_log.*log(h_log-hst)); sum(log(h_log-hst))];
sol=a\b; %impartire la stanga
T=-1/sol(1)

A=[-1/T]; B=[k/T]; C=[1]; D=[0];
figure
hsim=lsim(A,B,C,D,u,t,h(1));
plot(t,[u h hsim])
eMPN=norm(h-hsim)/norm(h-mean(h))