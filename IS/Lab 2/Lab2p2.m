%pt sistem de ordin 2
t=scope16(:,1);
u=scope16(:,2);
y=scope16(:,3);

i1=300;
i2=475;
plot(t,[u,y])
yst=mean(y(i1:i2));
ust=mean(u(i1:i2));
k=yst/ust;

i3=132;
i4=195;
i5=257;

sigma=sum(abs(y(i4:i5)-yst))/sum(y(i3:i4)-yst)
zeta=-log(sigma)/sqrt(pi^2+(log(sigma)^2))

i6=135;
i7=213;

wosc=pi/(t(i7)-t(i6))
wn=pi/((t(i7)-t(i6))*sqrt(1-zeta^2))

A=[0 1;-wn^2 -2*zeta*wn];
B=[0; k*wn^2];
C=[1 0];
D=[0];

figure
ysim=lsim(A,B,C,D,u,t,[y(1),0]);
plot(t,[u y ysim])
eMPN=norm(y-ysim)/norm(y-mean(y))