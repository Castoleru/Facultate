t=treapta0(:,1);
u=treapta0(:,2);
y=treapta0(:,3);
plot(t,[u,y]) %intrare/iesire

i1=297; i2=501; i3=600; i4=813;
yst=mean(y(i3:i4));
ust=mean(u(i3:i4));
y0=mean(y(i1:i2));
u0=mean(u(i1:i2));
k=(yst-y0)/(ust-u0);

yT=0.63*(yst-y0)+y0; %0.63=e^-1
hold on
plot(t,yT*ones(1,length(t)),'r')

i5=507; %intersectia dintre yt si dreapta orizontala
T=t(i5)-t(i2);

H=tf(k,[T 1]);
ysim=lsim(H,u,t); 
hold on
plot(t,ysim,'g')

figure
%Pt CI!=0
A=-1/T; B=k/T; C=1; D=0;
ysim1=lsim(A,B,C,D,u,t,y(1));
plot(t,[u,y,ysim1])