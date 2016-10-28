Program controlWrite;
uses Crt;
var i:integer;
    flag:boolean;
label s;
BEGIN
 {$I-}
  Repeat
  readln(i);
  if  IoResult <> 0 then
  begin
   gotoxy(wherex,wherey-1);
   delline;
  end
   else flag:=true;
  Until flag;
  {$I+}
END.
