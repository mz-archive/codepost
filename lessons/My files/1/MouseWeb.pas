uses GraphABC, Events;

var x1,y1: integer;

procedure Draw(x,y: integer);
const n=5;
var i,j: integer;
begin
  for i:=0 to n do
  for j:=0 to n do
    if (i=0) or (i=n) or (j=0) or (j=n) then
      Line(x,y,i*WindowWidth div n,j*WindowHeight div n);
end;

procedure MouseMove(x,y,mb:integer);
begin
  if x1<>-1 then Draw(x1,y1);
  Draw(x,y);
  x1:=x; y1:=y;
end;

procedure Resize;
begin
  ClearWindow;
  x1:=-1;
end;

begin
  SetWindowCaption('Паутина');
  OnMouseMove:=MouseMove;
  OnResize:=Resize;
  SetPenMode(pmNot);
  x1:=-1;
end.
