/* 
*  Replace comments
*  SaliproPham
*/
a = document.getElementById('comments');
if (a) {
	b = a.getElementsByTagName("DD");
	for (i = 0; i < b.length; i++) {
		if (b.item(i).getAttribute('CLASS') == 'comment-body') {
			callSmile(b);
			
			
			
		}
	}
}
aa = document.getElementById('HTML6');
if (aa) {
	bb = aa.getElementsByTagName("div");
	for (i = 0; i < bb.length; i++) {
		if (bb.item(i).getAttribute('CLASS') == 'rc-comments') {
			callSmile(bb);
			
			
			
		}
	}
}
function callSmile(b) {
			w2b_b_smly = b.item(i).innerHTML.replace(/:\)\)/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/21.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/O:-\)/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/25.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-bd/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/113.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/7:\)/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/19.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/2\):\)/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/48.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:\)\]/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/100.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:\(\(/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/20.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:\(/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/2.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/\;\)/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/3.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:D/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/4.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/\;\;-\)/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/5.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/7:\P/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/47.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/~\X\(/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/102.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-\//gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/7.gif' alt='' class='w2bsmly'/>");			
			w2b_b_smly = w2b_b_smly.replace(/\/:\)/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/23.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:x/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/8.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:\P/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/10.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-\*/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/11.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/=\(\(/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/12.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-\S\S/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/42.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-\O/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/13.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/\X\(/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/14.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/B-\)/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/16.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/\#:-\S/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/18.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-S/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/17.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:7/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/15.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:\)/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/1.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/\(:\|/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/37.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:\|/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/22.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/=\)\)/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/24.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-B/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/26.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/=\;/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/27.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-c/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/101.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-h/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/103.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-t/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/104.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/8-7/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/105.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/\I-\)/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/28.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/8-\|/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/29.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/\L-\)/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/29.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-a/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/31.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-\$/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/32.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/\[-\(/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/33.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:\O\)/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/34.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/8-\}/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/35.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/2:-\P/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/36.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/=\P~/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/38.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-\?/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/39.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/#-o/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/40.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/=\D7/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/41.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/\@-\)/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/43.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:\^o/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/44.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-w/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/45.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/\X\_\X/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/109.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:\!\!/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/110.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/\\m\//gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/111.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:-q/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/112.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/\^\#\(\^/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/114.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/~O\)/ig, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/57.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/\@\};-/ig, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/53.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/=\D:/ig, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/41.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/:ar\!/ig, "<img src='http://l.yimg.com/a/i/us/msg/emoticons/pirate_2.gif' alt='' class='w2bsmly'/>");
			w2b_b_smly = w2b_b_smly.replace(/\[-\X/ig, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/68.gif' alt='' class='w2bsmly'/>")
			b.item(i).innerHTML = w2b_b_smly;
}

/* 
*  Replace body
*  SaliproPham
*/
  var aaa = document.getElementById('Blog1'); 
  if (aaa) {
	 var bbb = aaa.getElementsByTagName('div');
	 for (i = 0; i < bbb.length; i++) {
		if (bbb.item(i).getAttribute('CLASS') == 'post-body entry-content') {
		nd = bbb.item(i).innerHTML.replace(/#bl0/gi, "<span class='tag'></span>"); 
        nd = nd.replace(/#bl1/gi, "<span class='bullet0'></span>");
		nd = nd.replace(/#bl2/gi, "<span class='bullet1'></span>");
		nd = nd.replace(/#bl3/gi, "<span class='bullet2'></span>");
		nd = nd.replace(/#lnk/gi, "<span class='link'></span>");
		nd = nd.replace(/#bsrc/gi, "<span class='nguon'></span>");
		nd = nd.replace(/#blsrc/gi, "<span class='nguon'></span>");
		nd = nd.replace(/#bllink/gi, "<span class='link'></span>");
		nd = nd.replace(/#blkey/gi, "<span class='key'></span>");
		nd = nd.replace(/#bldown/gi, "<span class='downs'></span>");
		nd = nd.replace(/#note/gi, "<div class='note'>");
		nd = nd.replace(/#\/note/gi, "</div>");	 
		nd = nd.replace(/#code/gi, "<div class='scode'>");
		nd = nd.replace(/#\/code/gi, "</div>");	 
		nd = nd.replace(/@hanhphuc/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/1.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@buonngu/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/37.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@nhaymat/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/3.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@hoi/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/7.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@toatmohoi/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/18.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@tiensi/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/26.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@chodoi/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/45.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@hay/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/41.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@gaqua/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/112.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@cafe/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/57.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@ok/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/69.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@no/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/68.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@buon/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/2.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@love/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/8.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@leluoi/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/10.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@cuoibo/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/24.gif' alt='SaliproBlog'>");
		nd = nd.replace(/@tambiet/gi, "<img src='http://l.yimg.com/us.yimg.com/i/mesg/emoticons7/103.gif' alt='SaliproBlog'>");
		 
		 
		 
		 bbb.item(i).innerHTML = nd;
		}
	}
}