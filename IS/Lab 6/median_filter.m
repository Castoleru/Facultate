%filtru median
function filtered_signal=median_filter(input_signal,order)
N=length(input_signal);
N1=floor(order/2);

filtered_signal=zeros(N-2*N1,1);

for i=1+N1:N-N1
    signal_1=input_signal(i-N1:i+N1);
    signal_1=sort(signal_1);
    filtered_signal(i-N1)=signal_1(N1+1);
end
end
