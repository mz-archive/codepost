uses crt;
var m:integer;
    n:char;
BEGIN
Clrscr;
Repeat
inc(m);
WriteLn(m);
WriteLn('������ ����������?- ������� Enter ��� Esc ����� �����');
n:=readkey;
UNtil n = #27;
END.
