program factproc;
Uses crt;
var i,z,x,l,g:integer;
    A:real;
procedure fact (n,m:integer);
begin
 z:=1;
     for i:=1 to n do   {��������� n}
      begin
       z:=z * i;
     end;
     
     l:=n-m;
     g:=1;
     
     for i:=1 to l do      {��������� n-m}
      begin
       g:=g * i;
     end;

     A:=z/g;       {���������}
end;
BEGIN
clrscr;
        fact(6,4);   {������������ �������� n,m}
        Writeln(A:0:0);   {��������������� ����� ����������}
Readln;
END.
