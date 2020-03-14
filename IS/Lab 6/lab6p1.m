N=10; i=7; j=10;
reg=ones(1,N);
for k=N+1:2^N-1
    reg=[xor(reg(i),reg(j)) reg];
end
reg=fliplr(reg);
stem(reg)

%%
figure
t=0:0.01:10;
vin=t/10;
x=vco(vin,45,100);
plot(t,x)

%%
u_filtru=zeros(length(u),1);
ord=5;
N1=floor(ord/2);
u_filtru(1+N1:length(u)-N1)=median_filter(u,ord);
for i=1:N1
    u_filtru(i)=u_filtru(N1+1);
    u_filtru(length(u)-i+1)=u_filtru(length(u)-N1);
end
