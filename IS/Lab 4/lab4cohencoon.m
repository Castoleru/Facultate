t=scope128(:,1);
u=scope128(:,2);
y=scope128(:,4);

t=t-t(1); %muta t initial in 0;
plot(t,[u,y])

i1=339;
i2=501;
i3=742;
i4=923;

y0=mean(y(i1:i2));
yst=mean(y(i3:i4));
u0=mean(u(i1:i2));
ust=mean(u(i3:i4));
k=(yst-y0)/(ust-u0);

hold on
y28=0.28*(yst-y0)+y0;
plot(t,y28*ones(1,length(t)),'g')

hold on
y63=0.63*(yst-y0)+y0;
plot(t,y63*ones(1,length(t)),'g')

i5=542;
i6=586;

t28=t(i5)-t(i2);
t63=t(i6)-t(i2);

T=1.5*(t63-t28);
tm=1.5*(t28-1/3*t63);

A=[-1/T]; B=[k/T]; C=[1]; D=[0]; %FCOb=Forma Canonica de Observare

figure
u_tau_m=[u(1)*ones(1,round(tm/(t(2)-t(1)))) u(1:(length(u)-round(tm/(t(2)-t(1)))))'];
ysim=lsim(A,B,C,D,u_tau_m,t,y(1));
plot(t,u,'b',t,y,'y',t,ysim,'g')
eMPN=norm(y-ysim)/norm(y-mean(y))



