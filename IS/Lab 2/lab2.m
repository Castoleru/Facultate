t=impuls0(:,1);
u=impuls0(:,2);
y=impuls0(:,3);

plot(t,[u,y])
i1=345;
i2=440;

yst=mean(y(i1:i2));
ust=mean(u(i1:i2));
k=yst/ust;

i3=236;
ymax=y(i3);
yT=0.37*(ymax-yst)+yst;
hold on
plot(t,yT*ones(1,length(t)),'r')
i4=250;
T=t(i4)-t(i3);

figure
A=[-1/T]; B=[k/T]; C=[1]; D=[0]; %FCOb=Forma Canonica de Observare
ysim=lsim(A,B,C,D,u,t,y(1));
plot(t,[u,y,ysim])
eMPN=norm(y-ysim)/norm(y-mean(y))