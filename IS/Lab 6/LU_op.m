function[y]=LU_op(u,ord,type)

N=length(u);
y=zeros(N,1);

if type=='L'
    for i=ord:N-ord+1
        u_loc=zeros(1,ord);
        for j=1:ord
            u_loc(j)=min(u(i-ord+j:i+j-1));
        end
        y(i)=max(u_loc);
    end
    for i=1:ord-1   
        y(i)=y(ord);
        y(N-i+1)=y(N-ord);
    end
elseif type=='U'
    for i=ord:N-ord+1
        u_loc=zeros(1,ord);
        for j=1:ord
            u_loc(j)=max(u(i-ord+j:i+j-1));
        end
        y(i)=min(u_loc);
    end
    for i=1:ord-1   
        y(i)=y(ord);
        y(N-i+1)=y(N-ord);
    end
else
    error('There is no such operator!');
end

end