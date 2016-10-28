uses ABCObjects,Events;

var
  jd: StarABC;
  r: RectangleABC;
  i: integer;

procedure CheckPulyaIntersects;
var i: integer;
begin
  for i:=ObjectsCount-1 downto 1 do
    if jd.Intersect(Objects[i]) then
      Objects[i].Destroy;
end;

 procedure MouseDown(x,y,mb:integer);
 var xh,yh:integer;
 begin
  xh:=(x-jd.left) div 20;
  yh:=(y-jd.top) div 20;
  for i:=1 to 20 do
  begin
   CheckPulyaIntersects;
   jd.moveto(jd.left+xh,jd.top+yh);
   sleep(30)
  end;
end;

begin
  for i:=1 to 300 do
   r:=CreateRectangleABC(Random(WindowWidth-200)+100,Random(WindowHeight-100),Random(200),Random(200),clRandom);
  jd:=StarABC.Create(200,100,70,35,5,clRed);
OnMouseDown:=MouseDown;
end.