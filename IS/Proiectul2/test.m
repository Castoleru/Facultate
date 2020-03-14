h1=tf(3065,[1 12.62]);
y_sim1=lsim(h1,d,t);
plot(t,[y_sim1 w])

figure
h2=tf(5.152,[1 0]);
y_sim2=lsim(h2,w,t);
plot(t,[y_sim2+theta(1) theta]);

figure
h1p2=c2d(h1,t(2)-t(1),'zoh');
[num,den]=tfdata(h1p2,'v');
y_sim1=dlsim(num, den,d);
plot(t,[y_sim1 w])

figure 
h2p2=c2d(h2,t(2)-t(1),'zoh');
[num,den]=tfdata(h2,'v');
y_sim2=lsim(num, den,w,t);
plot(t,y_sim2)

h2p3=d2c(h2p2,'zoh')