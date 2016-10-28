program TableUM;
Uses crt;
var i,f,z:integer;
BEGIN
clrscr;
       for i:=2 to 4 do
           for f:=1 to 10 do
               begin
                    z:=i*f;
                    Writeln(i,' * ',f,' = ',z);
               end;
       readln;
END.