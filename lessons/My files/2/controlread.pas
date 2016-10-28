Program controlWrite;
uses Crt;
var i:integer;
    flag:boolean;
BEGIN
  Repeat
  readln(i);
  if IoResult = 0 then flag:=true
  else
      begin
       gotoxy(wherex,wherey-1);
       delline;
      end;
  Until flag;
END.
