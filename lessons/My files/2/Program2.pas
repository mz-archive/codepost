uses crt;
var m:integer;
    n:char;
BEGIN
Clrscr;
Repeat
inc(m);
WriteLn(m);
WriteLn('Хотите продолжить?- нажмите Enter или Esc чтобы выйти');
n:=readkey;
UNtil n = #27;
END.
