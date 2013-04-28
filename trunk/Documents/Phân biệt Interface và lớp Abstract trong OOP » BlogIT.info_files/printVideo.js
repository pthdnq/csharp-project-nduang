
function printAudio(file) {
var html = "<div class='single-video'>";
html +="<embed type='application/x-shockwave-flash' id='single2' name='single2' src='http://salipro4ever.99k.org/blog/flashplayer/player.swf' width='600' height='360'";
html+="allowscriptaccess='always' allowfullscreen='true' wmode='transparent'";
html+="flashvars='file="+file+"&skin=http://salipro4ever.99k.org/blog/flashplayer/eleganttwilight.zip&volume=90&autostart=false&repeat=none&shuffle=false&dock=false' style='margin-top: -5px;'/></div>";
document.write(html);
}
