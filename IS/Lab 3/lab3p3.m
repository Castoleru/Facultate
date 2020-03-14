close all

%grad 2 raspuns treapta

t=scope128(:,1);
u=scope128(:,2);
y=scope128(:,4);
t=t-t(1); %muta t initial in 0;

plot(t,[u,y])
i1=16;
i2=65;
i3=348;
i4=460;

y0=mean(y(i1:i2));
u0=mean(u(i1:i2));
yst=mean(y(i3:i4));
ust=mean(u(i3:i4));
k=(yst-y0)/(ust-u0);

i5=108;
i6=200;
t_log=t(i5:i6);
y_log=y(i5:i6);
a=[sum(t_log.^2) sum(t_log); sum(t_log) length(t_log)];
b=[sum(t_log.*log(y_log-yst)); sum(log(y_log-yst))];
sol=a\b; %impartire la stanga
T1=-1/sol(1);

i7=300;
i8=310;
t_log2=t(i7:i8);
y_log2=y(i7:i8)-k*exp(-t_log2/T1);
a=[sum(t_log2.^2) sum(t_log2); sum(t_log2) length(t_log2)];
b=[sum(t_log2.*log(y_log2-yst)); sum(log(y_log2-yst))];
sol=a\b; %impartire la stanga
T2=-1/sol(1)

A=[0 1;-1/(T1*T2) -(T1+T2)/(T1*T2)];
B=[0; k/(T1*T2)]; C=[1 0]; D=[0];
hold on
hsim=lsim(A,B,C,D,u,t,[h(1) 0]);
plot(t,[u h hsim])
eMPN=norm(h-hsim)/norm(h-mean(h))




