program bukvi;
Uses crt;
var n,i,x:longint;
    h:real;
BEGIN
     clrscr;
     Writeln('������� �������� ��������');
     Readln(n);
     Writeln('������� ������ ����� ��������?');
     Readln(x);

     for i:=1 to n do

         begin
         TextColor(12);
         h:=exp(ln(x)*i);
         Writeln(x,' � ',i,' -�� = ',h:0:1);
         end;
         
         Readln;
     end.


         
