program MyProgram;
uses crt;
type TextFile = text;
type z = Record
     id:integer;
     stud:string;
     number:integer;
     dom_num:integer;
     yl:string;
end;
var  student:array [1..1000] of z;
     i,m,n:Integer;
     list:TextFile;
     key:char;
     v:boolean;
Label met;
BEGIN
  ClrScr;
  Assign(list,'F:\\��\2 ����\��������������\list_stud.txt');
  Repeat
  Writeln('������� 1 ���� ������ �������� ������');
  Writeln('������� 2 ���� ������ ������� ������');
  Writeln('������� 3 ���� ������ ������� ������');
  Writeln('������� 0 ���� ������ ������� ������');
  case ReadKey of
       #48:
           begin
            Goto met;
           end;
       #49:
           begin
             ReWrite(list);
             WriteLn('������� ������� ��������?');
             Read(n);
             WriteLn('������� ����� ������ <���, ����� ��������, ����� ����, �����>');
             for i:=1 to n do
                 begin
                   WriteLn('������� ',i,'-�� ������');
                   ReadLn(list, student[i].stud, student[i].number, student[i].dom_num, student[i].yl);
                   WriteLn(list, student[i].stud, student[i].number, student[i].dom_num, student[i].yl);
                 end;
             close(list);
           end;

  end;
  Until v;
met:
WriteLn('�����');
ReadLn;
END.
