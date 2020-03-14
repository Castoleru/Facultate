close all;
clc;

Hf=tf(4,[1 2 0]);
Hr=tf([41.7 , 4.41*41.7],[1 18.4]);
Hdes=series(Hr,Hf);
nichols(Hdes)
hold on
nichols(Hf)

%MdB=1.25;
MdB=1.85;
M=10^(MdB/20);
r=abs(M/(M^2-1));
X0=-M^2/(M^2-1);
Y0=0;

Ts=0.01;
t=Ts:Ts:pi;

X=X0+r*cos(t);
Y=Y0+r*sin(t);
mag=db(sqrt(X.^2+Y.^2));
ph=atan2(Y,X);

hold on;
plot(rad2deg(ph)-360,mag);

t=pi+Ts:Ts:2*pi;

X=X0+r*cos(t);
Y=Y0+r*sin(t);
mag=db(sqrt(X.^2+Y.^2));
ph=atan2(Y,X);


hold on;
plot(rad2deg(ph),mag);

figure;
H0=feedback(Hf,1);
bode(H0);