Program controlWrite;
uses Crt;
var i:integer;
    flag:boolean;
BEGIN
  Repeat
  try
  readln(i);
  if except then flag:=true
  else
  begin
  gotoxy(wherex,wherey-1);
  delline;
  end;
  Until flag;
END.
