{����� ������� ������� ����������� ���������}
program Newton;
uses crt;

function f(x:real):real; {�������� �������}
begin
 f:=6*sqr(x)+4*x-1;
end;

function f1(x:real):real; {������ ����������� �������}
begin
 f1:=12*x+4;
end;

var a,b,x,e,en:real;
    i:integer;

begin
 clrscr; {�������� �����}
 writeln ('������� ����������� ��������� ������� �������');
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