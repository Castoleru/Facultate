t=scope128(:,1);
u=scope128(:,2);
y=scope128(:,3);

t=t-t(1); %muta t initial in 0;
plot(t,[u,y])

i1=396;
i2=501;
i3=770;
i4=850;

y0=mean(y(i1:i2));
yst=mean(y(i3:i4));
u0=mean(u(i1:i2));
ust=mean(u(i3:i4));
k=(yst-y0)/(ust-u0);

hold on
plot(t,yst*ones(1,length(t)),'g')

i5=560;
T=t(i5)-t(i2);

figure
A=[-1/T]; B=[k/T]; C=[1]; D=[0]; %FCOb=Forma Canonica de Observare
ysim=lsim(A,B,C,D,u,t,y(1));
plot(t,u,'b',t,y,'y',t,ysim,'g')
eMPN=norm(y-ysim)/norm(y-mean(y))