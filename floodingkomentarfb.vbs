dim wsh
jumlah=3
delay=1
set wsh=wscript.createobject("wscript.shell")
wscript.sleep 3000

for i=1 to jumlah
wsh.sendkeys "Flooder Spam Test"
wsh.sendkeys "{ENTER}"
wsh.sendkeys "Jangan Lupa Follow Instagram : @pcmdh"
wsh.sendkeys "{ENTER}"
wsh.sendkeys "Terima Kasih ^^"
wsh.sendkeys "{ENTER}"
next

'END