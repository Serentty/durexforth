variable spritex 0 spritex !
variable spritey 0 spritey !

0 value gfxloc
0 value spriteloc
: calc-gfxloc
spritex @ 8 *
spritey @ 140 * +
bmpbase + to gfxloc ;
: write ( spriteoffset gfxoffset -- )
gfxloc + tuck c@
swap spriteloc + c@ or
swap c! ;

: sprite create
here 3f allot sp-data
does> ( addr -- )
kernal-out
to spriteloc calc-gfxloc
8 0 do
i 3 * i
over 1+ over 8 +
over 1+ over 8 +
write write write
i 3 * 18 + i 140 +
over 1+ over 8 +
over 1+ over 8 +
write write write
loop
5 0 do
i 3 * 30 + i 280 +
over 1+ over 8 +
over 1+ over 8 +
write write write
loop kernal-in ;

: new-symbol 3 spritex +! ;

sprite t30
........................
........................
........................
........................
........................
........................
.......33...44...4......
......3..4.4..4.4.4.....
.........4.4..4..4......
.......44..4..4.........
.........4.4..4.........
.........4.4..4.........
......3..4.4..4.........
.......33...44..........
........................
........................
........................
........................
........................
........................
........................

sprite t40
........................
........................
........................
........................
........................
........................
......4..4..44...4......
......4..4.4..4.4.4.....
......4..4.4..4..4......
......4444.4..4.........
.........4.4..4.........
.........4.4..4.........
.........4.4..4.........
.........4..44..........
........................
........................
........................
........................
........................
........................
........................

sprite t60
........................
........................
........................
........................
........................
........................
.......55...aa...4......
......5..a.4..4.4.4.....
......6....4..4..4......
......6aa..4..4.........
......6..6.4..4.........
......6..6.4..4.........
......6..6.4..4.........
.......66...44..........
........................
........................
........................
........................
........................
........................
........................

sprite t95
........................
........................
........................
........................
........................
........................
.......44..5555..4......
......4..4.5....4.4.....
......9..9.5.....4......
......9..9.5l5..........
.......446....4.........
.........6....4.........
.........6.4..4.........
.......66...44..........
........................
........................
........................
........................
........................
........................
........................

sprite x
........................
........................
........................
x......................x
.xx..................xx.
...xx..............xx...
.....xx..........xx.....
.......xx......xx.......
.........xx..xx.........
...........xx...........
.........xx..xx.........
.......xx......xx.......
.....xx..........xx.....
...xx..............xx...
.xx..................xx.
x......................x
........................
........................
........................
........................
........................

sprite gentle
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
....4444444444444444....
........................
........................

sprite very-gentle
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................
....4444444444444444....
........................
....4444444444444444....

sprite wash
........................
.4....................4.
.4...44....44....44...4.
.44.4..4..4..4..4..4.44.
.444....44....44....444.
..4..................4..
..4..................4..
..44................44..
..44................44..
...4................4...
...4................4...
...44..............44...
...44..............44...
....4..............4....
....4..............4....
....44............44....
....4444444444444444....
........................
........................
........................
........................

sprite handwash
........h.......h.......
........h.......h.......
........h.......h.......
........h.......h.......
.4.....h.........h....4.
.4...44....l.....h4...4.
.44.4.h..ll......h.4.44.
.444..h.j........h..444.
..4...h.h.h......h...4..
..4...h.h..h.h.h.h...4..
..44...h.h.h.h.h.h..44..
..44.....h.h.h.h.h..44..
...4.....h.h.h.h.h..4...
...4.....h.h.h.hh...4...
...44....h.h.h.h...44...
...44.....hh.hh....44...
....4.......h......4....
....4..............4....
....44............44....
....4444444444444444....
........................

sprite bleach
...........xx...........
..........x..x..........
..........x..x..........
.........x....x.........
........x......x........
........x......x........
.......x........x.......
......x..........x......
......x..........x......
.....x............x.....
....x..............x....
....x..............x....
...x................x...
..x..................x..
..x..................x..
.x....................x.
x......................x
xxxxxxxxxxxxxxxxxxxxxxxx
........................
........................
........................

sprite bleach-ncl
...........xx...........
..........x..x..........
..........x..x..........
.........x....x.........
........x.....xx........
........x.....xx........
.......x.....x..x.......
......x.....x....x......
......x.....x....x......
.....x.....x.....xx.....
....x.....x.....x..x....
....x.....x.....x..x....
...x.....x.....x....x...
..x.....x.....x......x..
..x.....x.....x......x..
.x.....x.....x........x.
x.....x.....x..........x
xxxxxxxxxxxxxxxxxxxxxxxx
........................
........................
........................

sprite circle
........................
........................
.........xxxxxx.........
.......xxx....xxx.......
......xx........xx......
.....xx..........xx.....
.....x............x.....
....xx............xx....
....x..............x....
....x..............x....
....x..............x....
....x..............x....
....xx............xx....
.....x............x.....
.....xx..........xx.....
......xx........xx......
.......xxx....xxx.......
.........xxxxxx.........
........................
........................
........................

sprite box
........................
...xxxxxxxxxxxxxxxxxx...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...xxxxxxxxxxxxxxxxxx...
........................
........................

sprite circle-full
........................
........................
.........xxxxxx.........
.......xxxxxxxxxx.......
......xxxxxxxxxxxx......
.....xxxxxxxxxxxxxx.....
.....xxxxxxxxxxxxxx.....
....xxxxxxxxxxxxxxxx....
....xxxxxxxxxxxxxxxx....
....xxxxxxxxxxxxxxxx....
....xxxxxxxxxxxxxxxx....
....xxxxxxxxxxxxxxxx....
....xxxxxxxxxxxxxxxx....
.....xxxxxxxxxxxxxx.....
.....xxxxxxxxxxxxxx.....
......xxxxxxxxxxxx......
.......xxxxxxxxxx.......
.........xxxxxx.........
........................
........................
........................

sprite dot1
........................
........................
........................
........................
........................
........................
........................
........................
........................
...........xx...........
...........xx...........
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................

sprite dot2
........................
........................
........................
........................
........................
........................
........................
........................
........................
.........xx..xx.........
.........xx..xx.........
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................

sprite dot3
........................
........................
........................
........................
........................
........................
........................
........................
........................
.......xx..xx..xx.......
.......xx..xx..xx.......
........................
........................
........................
........................
........................
........................
........................
........................
........................
........................

sprite iron
....xxxxxxxxxxxxxxx.....
..................x.....
..................x.....
..................x.....
...................x....
.......xxxxxxxxxxxxx....
.....xx............x....
....x..............x....
...x................x...
...x................x...
..x.................x...
..x.................x...
..x..................x..
..x..................x..
..xxxxxxxxxxxxxxxxxxxx..
........................
........................
........................
........................
........................
........................

sprite strykjarn-anga
....xxxxxxxxxxxxxxx.....
..................x.....
..................x.....
..................x.....
...................x....
.......xxxxxxxxxxxxx....
.....xx............x....
....x..............x....
...x................x...
...x................x...
..x.................x...
..x.................x...
..x..................x..
..x..................x..
..xxxxxxxxxxxxxxxxxxxx..
....xx...x....x...xx....
......xxxx....xxxx......
........x.xxxx.x........
......xxxx....xxxx......
....xx.x........x.xx....
.......x........x.......

sprite dry-line
........................
...xxxxxxxxxxxxxxxxxx...
...xx..............xx...
...x.x............x.x...
...x..xxx......xxx..x...
...x.....xxxxxx.....x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...xxxxxxxxxxxxxxxxxx...
........................
........................

sprite dry-drip
........................
...xxxxxxxxxxxxxxxxxx...
...x................x...
...x................x...
...x................x...
...x...xx..xx..xx...x...
...x...xx..xx..xx...x...
...x...xx..xx..xx...x...
...x...xx..xx..xx...x...
...x...xx..xx..xx...x...
...x...xx..xx..xx...x...
...x...xx..xx..xx...x...
...x...xx..xx..xx...x...
...x...xx..xx..xx...x...
...x...xx..xx..xx...x...
...x................x...
...x................x...
...x................x...
...xxxxxxxxxxxxxxxxxx...
........................
........................

sprite dry-flat
........................
...xxxxxxxxxxxxxxxxxx...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x...xxxxxxxxxx...x...
...x...xxxxxxxxxx...x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...xxxxxxxxxxxxxxxxxx...
........................
........................

sprite shade
........................
...xxxxxxxxxxxxxxxxxx...
...x....x....x......x...
...x...x....x.......x...
...x..x....x........x...
...x.x....x.........x...
...xx....x..........x...
...x....x...........x...
...x...x............x...
...x..x.............x...
...x.x..............x...
...xx...............x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...x................x...
...xxxxxxxxxxxxxxxxxx...
........................
........................

sprite vrid-ej-ur
........................
........................
........................
.....x............x.....
......x..........x......
.......x........x.......
.xxxxx..x.xxxxxx...xxxx.
.x....x.xx....x.x.x...x.
.x.....x..x..x...x....x.
.x.....x...xx....x....x.
.x....x....xx...x.....x.
.x....x...x..x.xx.....x.
.x...x.h.x...xx..x....x.
.xxxx...xxxxx..x..xxxxx.
.......x........x.......
......x..........x......
.....x............x.....
........................
........................
........................
........................

sprite chem-p
........................
.........xxxxxx.........
.......xxx....xxx.......
......xx........xx......
.....xx..........xx.....
.....x...pppppp...x.....
....x....p.....p...x....
....x....p.....p...x....
....x....p.....p...x....
....x....ppoooo....x....
....x....p.........x....
....xx...p........xx....
.....x...p........x.....
.....xx..........xx.....
......xx........xx......
.......xxx....xxx.......
.........xxxxxx.........
........................
........................
........................
........................

sprite chem-a
........................
.........xxxxxx.........
.......xxx....xxx.......
......xx........xx......
.....xx..........xx.....
.....x....pppp....x.....
....x....p....p....x....
....x....p....p....x....
....x....p....p....x....
....x....ppoooa....x....
....x....p....a....x....
....xx...p....a...xx....
.....x...p....a...x.....
.....xx..........xx.....
......xx........xx......
.......xxx....xxx.......
.........xxxxxx.........
........................
........................
........................
........................

sprite chem-f
........................
.........xxxxxx.........
.......xxx....xxx.......
......xx........xx......
.....xx..........xx.....
.....x...fppppf...x.....
....x....p.........x....
....x....p.........x....
....x....p.........x....
....x....ppooo.....x....
....x....p.........x....
....xx...p........xx....
.....x...p........x.....
.....xx..........xx.....
......xx........xx......
.......xxx....xxx.......
.........xxxxxx.........
........................
........................
........................
........................

sprite chem-w
........................
........xxxxxxx.........
......xxx.....xxx.......
.....xx.........xx......
....xx...........xx.....
....x...f..f..f...x.....
...x....p..f..f....x....
...x....p..f..f....x....
...x....p..f..f....x....
...x....p. f..f....x....
...x....p..f..f....x....
...xx...p..l..f...xx....
....x... ll.lf....x.....
....xx...........xx.....
.....xx.........xx......
......xxx.....xxx.......
........xxxxxxx.........
........................
........................
........................
........................
