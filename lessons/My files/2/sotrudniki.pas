{�������� ��������: �������� ��������� ������� ������ - ������ ������� �������� ��������������� �����
 ���������� ���������� ��� ���������� ������ ������� � ������(2-�� ��������) - �� ������
 ������������� ������� ��������, �� ��� �������������� �������� ������ � ����� �������� ������� ����� �� ���������}
program zapisi;
uses crt;
type rec = record
     name:string[70];
     fam:string[70];
     oklad:integer;
end;
const n = 60;
var mofr:array [1..n] of rec;
    count_status,mylist:text;
    exit_prog:boolean;
    i,count_rec:longint;
    int:integer;
    
procedure add_human;
  begin
  WriteLn('');
  Reset(count_status);
  Read(count_status, count_rec);
  Close(count_status);
  if n = count_rec then WriteLn('������ �������� ��������� �����������!') else
  begin
  TextColor(9);
  Writeln('������� � ���� �������: "��� <ENTER> ������� <ENTER> ����� <ENTER>"');
  TextColor(0);
  Reset(count_status);
  Read(count_status, count_rec);
  Close(count_status);
  inc(count_rec);
    Append(mylist);
    ReadLn(mofr[count_rec].name, mofr[count_rec].fam, mofr[count_rec].oklad);
    WriteLn(mylist, count_rec,' : ', mofr[count_rec].name, ' : ', mofr[count_rec].fam,' : ',mofr[count_rec].oklad);
    Close(mylist);
  ReWrite(count_status);
  Write(count_status,count_rec);
  Close(count_status);
  end;
  ReadLn;
  end;

procedure print_human;
  begin
  Reset(count_status);
  Read(count_status, count_rec);
  Close(count_status);
   TextColor(10);
   WriteLn('---------------------------------------------------------------');
   TextColor(9);
   Reset(mylist);
   for i:=1 to count_rec do
   begin
   Read(mylist,mofr[i].name,mofr[i].fam, mofr[i].oklad);
   WriteLn(i,' : ',mofr[i].name,' : ',mofr[i].fam,' : ',mofr[i].oklad);
   end;
   Close(mylist);
   TextColor(10);
   WriteLn('-----------------------------------------------------------------');
   ReadLn;
  end;
  
procedure system_information;
  begin
  Reset(count_status);
  Read(count_status, count_rec);
  Close(count_status);
    TextColor(10);
    WriteLn('------------------------------');
    TextColor(12);
    WriteLn('����������� ������� - ',n);
    {���-�� ������� � ����� - count_rec}
    WriteLn('������� � ����� - ',count_rec);
    WriteLn('��� ����� ������ - ',n-count_rec);
    TextColor(10);
    WriteLn('------------------------------');
    ReadLn;
  end;
BEGIN
ClrScr;
Assign(mylist,'G:\mylist.txt');
Assign(count_status,'G:\count_status.txt');
Repeat
Clrscr;
TextColor(0);
WriteLn('d - �������� ����������');
WriteLn('p - ������� ����������� <������� ���������>');
WriteLn('i - ��� ����������');
WriteLn('0 - ����� �� ���������');
case readkey of
     #100:add_human;
     #112:print_human;
     #105:system_information;
     #48:exit_prog:=true;
end;
Until exit_prog;

END.
