program factproc;
Uses crt;
var i,z,x,l,g,y:integer;
    A:real;
procedure fact (n,m:integer);
begin
 z:=1;
 
     for i:=1 to n do     {��������� n}
     begin
       z:=z * i;
     end;

     l:=n-m;
     g:=1;
     
     for i:=1 to l do {��������� n-m}
     begin
       g:=g * i;
     end;

     y:=1;
     
     for i:=1 to m do   {��������� m}
     begin
       y:=y * i;
     end;
     
     A:=z/(y*g);  {���������}
end;
BEGIN
clrscr;
        fact(8,2);  {������������ �������� n,m}
        Writeln(A:0:0);    {��������������� ����� ����������}
Readln;
END.
