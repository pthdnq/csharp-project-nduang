
function printAudio(file) {
var html = "<div class='single-audio'>";
html += '<embed allowfullscreen="false" allowscriptaccess="always" height="48" menu="false" quality="high" ';
html += 'src="http://salipro4ever.99k.org/blog/flashplayer/music.swf" type="application/x-shockwave-flash" width="400" wmode="transparent"/>';
html +="<embed type='application/x-shockwave-flash' id='single2' name='single2' src='http://salipro4ever.99k.org/blog/flashplayer/player.swf' width='400' height='36'";
html+="allowscriptaccess='always' allowfullscreen='true' wmode='transparent'";
html+="flashvars='file="+file+"&skin=http://salipro4ever.99k.org/blog/flashplayer/eleganttwilight.zip&volume=90&autostart=false&repeat=none&shuffle=false&dock=false' style='margin-top: -5px;'/></div>";
document.write(html);
}
