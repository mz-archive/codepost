program factproc;
Uses crt;
var i,z,x:integer;
procedure fact (n:integer);
begin
 z:=1;
     for i:=1 to n do
      begin
       z:=z * i;
     end;
end;
BEGIN
clrscr;
       Write('������� ����� ��� ���������� ���������� =  ');
       Readln(x);
       fact(x);
       TextColor(12);
       WriteLn('���������:');
       TextColor(2);
       Writeln(x,'! = ',z);
Readln;
END.
