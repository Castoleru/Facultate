t=double(pop_denis.X.Data)'; %ia campul x, .data si datele numerice si facem matrice coloana
d=double(pop_denis.Y(1,3).Data)'; %semnal de comanda
w=double(pop_denis.Y(1,2).Data)'; %viteza
theta=double(pop_denis.Y(1,1).Data)'; %pozitia
figure
subplot(311); plot(t,d);
subplot(312); plot(t,w); %viteza unghiulara
subplot(313); plot(t,theta); %pozitia unghiulara

