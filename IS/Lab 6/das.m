%% Mosoiu date
close all
y_fil=tukey53H(y);

plot(t,[u y_fil])


i1=10;
i2=40;
i3=422;
i4=450;

y0=mean(y(i1:i2));
yst=mean(y(i3:i4));
u0=mean(u(i1:i2));
ust=mean(u(i3:i4));
k=(yst-y0)/(ust-u0);

hold on
plot(t,yst*ones(1,length(t)),'g')
hold on
plot(t,y0*ones(1,length(t)),'g')

i5=50;
i6=105;
tm=t(i5)-t(i2);
T=t(i6)-t(i5);
h=
A=[-1/T]; B=[k/T]; C=[1]; D=[0]; %FCOb=Forma Canonica de Observare

figure
ysim=lsim(A,B,C,D,u,t,y(1));
plot(t,u,'b',t,y,'y',t,ysim,'g')
eMPN=norm(y-ysim)/norm(y-mean(y))
