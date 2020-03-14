function output_signal=tukey53H(input_signal)

N=length(input_signal);

u_median_5=median_filter(input_signal,5);
u_median_3=median_filter(u_median_5,3);

%Apply a Hanning window
output_signal=zeros(N,1);
for i=2:length(u_median_3)-1
    output_signal(i+3)=1/4*(u_median_3(i-1)+2*u_median_3(i)+u_median_3(i+1));
end
for i=1:4
    output_signal(i)=output_signal(5);
    output_signal(length(output_signal)-i)=output_signal(length(output_signal)-5);
end
end
