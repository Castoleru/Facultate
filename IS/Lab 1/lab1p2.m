t=treapta0(:,1);
u=treapta0(:,2);
y=treapta0(:,4);
plot(t,[u,y]) %intrare/iesire

i1=341; i2=501; i3=667; i4=815;
yst=mean(y(i3:i4));
ust=mean(u(i3:i4));
y0=mean(y(i1:i2));
u0=mean(y(i1:i2));
k=(yst-y0)/(ust-u0);

i5=580;
ymax=y(i5);
sigma=(ymax-yst)/(yst-y0);
zeta=-log(sigma)/sqrt(pi^2+(log(sigma))^2)

i6=663; 
tr=t(i6)-t(i2)
wn=4/(zeta*tr)

H=tf(k*wn^2,[1 2*zeta*wn wn^2]);
ysim=lsim(H,u,t);
hold on
plot(t,ysim,'g')

A=[0 1; -wn^2 -2*zeta*wn];
B=[0; k*wn^2];
C=[1 0];
D=0;
ysim1=lsim(A,B,C,D,u,t,[y(1),0]);
figure
plot(t,[u,y,ysim1])

J=norm(y-ysim1)
eMPN=norm(y-ysim1)/norm(y-mean(y))
