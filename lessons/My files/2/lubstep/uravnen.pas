Program uravnen;
uses crt;
var a,b,c,x1,x2,x3,x4,x5,x6,d:real;
    z,k,p,j,x:real;
    E:boolean;
    R:integer;
procedure kvad;
begin
 WriteLn('��������� ������ ��������� ���� a*x^2+b*x+c');
     WriteLn('������� A,B,C ');
     readln(z,k,p);
     j:=sqr(k)-4*z*p;
     if j<0 then
        begin
          WriteLn('�������������� ������ ���');
        end
     else if j = 0 then
        begin
          x:=(-k)/(2*z);
          WriteLn('������ ��������� ���� D=0 �� ������ = ',x:0:2);
        end
     else
         begin
           x:=(-k+sqrt(j))/(2*z);
           WriteLn('D>0');
           WriteLn('x1 = ',x:0:2);
           x:=(-k-sqrt(j))/(2*z);
           WriteLn('x2 = ',x:0:2);
         end;
end;
procedure bikvad;
begin
writeln('��������� ������ ������������ ��������� ���� a*x^4+b*x^2+c');
write('������� a= ');
read(a);
write('������� b= ');
read(b);
write('������� c= ');
read(c);
d:=b*b-4*a*c;
if d<0 then writeln('�������� �� ����� �������') else
 begin
 x1:=(-b+sqrt(d))/(2*a);
 x2:=(-b-sqrt(d))/(2*a);
 if (x1<0) and (x2<0) then writeln('�������� �� ����� �������') else
 begin
  if x1>=0 then
   begin
    x3:=sqrt(x1);
    x4:= -sqrt(x1);
    write('�����: ',x3,';',x4,';');
   end;
  if x2>=0 then
   begin
    x5:=sqrt(x2);
    x6:= -sqrt(x2);
    writeln(x5,' ;',x6,'.');
   end;
  end;
end;
end;
BEGIN
 ClrScr;
 TextColor(12);
 ClrScr;
 WriteLn('������� ������� 1 ����� ������ ���������� ���������');
 WriteLn('������� ������� 2 ����� ������ ������������ ���������');
 case ReadKey of
 #49:begin
      TextColor(green);
      kvad;
     end;
 #50:begin
      TextColor(4);
      bikvad;
     end;
 end;
END.