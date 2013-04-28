
function printZing(list) {
var html = "<div class='player'>";
html += '<embed id="player" wmode="transparent" allowscriptaccess="always" allowfullscreen="true" ';
html += 'src="http://static.mp3.zing.vn/skins/mp3_main/flash/zing_mp3_player_v1.5.swf" ';
html += 'flashvars="songid=0&amp;autostart=true&amp;xmlURL='+list+'&amp;skin=http://static.mp3.zing.vn/skins/mp3_main/flash/player_v1.2.swf&amp;config=http://static.mp3.zing.vn/skins/mp3_main/flash/config.xml">';
html += "</div>";
document.write(html);
}