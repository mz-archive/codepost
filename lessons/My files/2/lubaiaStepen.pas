{����� ������� ������� ����������� ���������}
program Newton;
uses crt; {������ ���������� �������}

function f(x:real):real; {�������� �������}
begin
 f:=sqr(sqr(x))-5*sqr(x)-x+1;
end;

function f1(x:real):real; {������ ����������� �������}
begin
 f1:=4*x*sqr(x)-10*x-1;
end;

var a,b,x,e,en:real;
    i:integer;

begin
 clrscr; {�������� �����}
 writeln ('������� ����������� ��������� ������� �������');
 writeln ('��������� x^4+5x^2-x+1=0');
 write ('������� ����� � ������ ������� ���������:');
 read (a,b);
 write ('������� ��������� �������� �������:');
 read (e);
 writeln ('�������:');
 writeln ('����� ���� �������� X');
 en:=abs(a-b);
 x:=b;
 i:=1;
 while (abs(en)>e) do begin {���� �� ���������� ��������}
  x:=x-f(x)/f1(x); {��������� ��� ������}
  writeln (i:10,x:20:14); {������� �������� X � ����}
  en:=abs(x-b); {����� ��������}
  b:=x; {�������� ������� ��� ���������� ����}
  i:=i+1; {����� ����}
 end;
end.