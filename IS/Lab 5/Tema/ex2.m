close all;
clc;

H=tf([50 5],conv(conv(conv([1 0],[100 1]),[1 1]),[0.5 1]));

nichols(H)

MdB=3;
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
H0=feedback(H,1);
bode(H0);