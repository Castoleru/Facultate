close all

%pt sistem de ordin 1 si treapta

t=scope128(:,1);
u=scope128(:,2);
y=scope128(:,3);
t=t-t(1); %muta t initial in 0;
plot(t,[u,y])

i1=20;
i2=72;
i3=340;
i4=432;

y0=mean(y(i1:i2));
yst=mean(y(i3:i4));
u0=mean(u(i1:i2));
ust=mean(u(i3:i4));
k=(yst-y0)/(ust-u0); %factor de proportionalitate aprox 2.10->2.11

i5=101;
i6=201;

t_log=t(i5:i6);
y_log=y(i5:i6);
 plot(t,y);hold on
 plot(t(i3:i4),y(i3:i4),'r');
a=[sum(t_log.^2) sum(t_log); sum(t_log) length(t_log)];
b=[sum(t_log.*log(y_log-yst)); sum(log(y_log-yst))];
sol=a\b; %impartire la stanga
T=-1/sol(1); %T=0.0106

A=[-1/T]; B=[k/T]; C=[1]; D=[0];
figure
ysim=lsim(A,B,C,D,u,t,y(1));
plot(t,[u y])
hold on
plot(t,ysim,'g')
eMPN=norm(y-ysim)/norm(y-mean(y)) %eroare de 0.0382




