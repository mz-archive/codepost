program bukvi;
Uses crt;
var n,i,x:integer;
    h:real;
BEGIN
     clrscr;
     Writeln('������� �������� ��������');
     Readln(n);
     Writeln('������� ������ ����� ��������?');
     Readln(x);

     Repeat
      inc(i);
         begin
         TextColor(12);
         h:=exp(ln(x)*i);
         Writeln(x,' � ',i,' -�� = ',h:0:1);
         end;
      UNTIL (i=n);
         Readln;
     end.


         
