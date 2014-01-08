using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Serialization;
using System.IO;

namespace SlideShareAPI.Test
{
    [TestClass]
    public class Serialization
    {
        /*
         * TODO: Better test coverage for common functions. 
         * Current tests were only added to validate changes for basis show search.
         */

        private static readonly String _apiKey = "";
        private static readonly String _secret = "";

        #region Big Xml Block
        private static readonly String _sampleSlideshows =@"<?xml version='1.0' encoding='UTF-8'?>
<Slideshows>
  <Meta>
    <Query>slideshare</Query>
    <ResultOffset>
</ResultOffset>
    <NumResults>16</NumResults>
    <TotalResults>16883</TotalResults>
  </Meta>
<Slideshow>
  <ID>11078523</ID>
  <Title>SlideShare Zeitgeist 2011</Title>
  <Description>
</Description>
  <Status>2</Status>
  <Username>rashmi</Username>
  <URL>http://www.slideshare.net/rashmi/slideshare-zeitgeist-2011</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/zeitgeist2011-120116062709-phpapp01-thumbnail.jpg?cb=1337574397</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/zeitgeist2011-120116062709-phpapp01-thumbnail-2.jpg?cb=1337574397</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/11078523&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/rashmi/slideshare-zeitgeist-2011&quot; title=&quot;SlideShare Zeitgeist 2011&quot; target=&quot;_blank&quot;&gt;SlideShare Zeitgeist 2011&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/rashmi&quot; target=&quot;_blank&quot;&gt;Rashmi Sinha&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2012-01-16 12:27:06 UTC</Created>
  <Updated>2012-05-21 04:26:37 UTC</Updated>
  <Language>en</Language>
  <Format>pdf</Format>
  <Download>1</Download>
  <DownloadUrl>http://s3.amazonaws.com/ppt-download/zeitgeist2011-120116062709-phpapp01.pdf?response-content-disposition=attachment&amp;Signature=Y9FV47uRBwn6UjNhLjl8A2Hiqy0%3D&amp;Expires=1389134793&amp;AWSAccessKeyId=AKIAIW74DRRRQSO4NIKA</DownloadUrl>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>10357489</ID>
  <Title>SlideShare Infographic: The Quiet Giant of Content Marketing</Title>
  <Description>Infographic on SlideShare and Content Marketing, produced in collaboration with CollumnFive. Sources of data: B2B Technology Marketing Community on LinkedIn, The Content Marketing Institute, SlideShare Zeigeist, Quantcast and Comscore.</Description>
  <Status>2</Status>
  <Username>slidesharepro</Username>
  <URL>http://www.slideshare.net/slidesharepro/slideshare-infographic-the-quiet-giant-of-content-marketing</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_cropped_thumbnails/11-11-17slidesharegiantv3-111127221433-phpapp01/thumbnail-small.jpg?cb=1374767619</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_cropped_thumbnails/11-11-17slidesharegiantv3-111127221433-phpapp01/thumbnail-extra_small.jpg?cb=1374767619</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/10357489&quot; width=&quot;479&quot; height=&quot;511&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/slidesharepro/slideshare-infographic-the-quiet-giant-of-content-marketing&quot; title=&quot;SlideShare Infographic: The Quiet Giant of Content Marketing&quot; target=&quot;_blank&quot;&gt;SlideShare Infographic: The Quiet Giant of Content Marketing&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/slidesharepro&quot; target=&quot;_blank&quot;&gt;SlideShare Content Marketing&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2011-11-28 04:14:32 UTC</Created>
  <Updated>2013-07-25 15:53:39 UTC</Updated>
  <Language>en</Language>
  <Format>pdf</Format>
  <Download>1</Download>
  <DownloadUrl>http://s3.amazonaws.com/ppt-download/11-11-17slidesharegiantv3-111127221433-phpapp01.pdf?response-content-disposition=attachment&amp;Signature=gT2DXjhN02qi7kVAR%2F37V%2BOB5dQ%3D&amp;Expires=1389134793&amp;AWSAccessKeyId=AKIAIW74DRRRQSO4NIKA</DownloadUrl>
  <SlideshowType>4</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>2576518</ID>
  <Title>Trovare risorse su Slideshare</Title>
  <Description>Un breve tutorial per gli allievi del corso Garamond &amp;quot;insegnare e apprendere con i social netowrk</Description>
  <Status>2</Status>
  <Username>giacomo.mason</Username>
  <URL>http://www.slideshare.net/giacomo.mason/trovare-risorse-su-slideshare</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/trovareslideshare-091124134526-phpapp02-thumbnail.jpg?cb=1259093779</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/trovareslideshare-091124134526-phpapp02-thumbnail-2.jpg?cb=1259093779</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/2576518&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/giacomo.mason/trovare-risorse-su-slideshare&quot; title=&quot;Trovare risorse su Slideshare&quot; target=&quot;_blank&quot;&gt;Trovare risorse su Slideshare&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/giacomo.mason&quot; target=&quot;_blank&quot;&gt;Giacomo Mason&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2009-11-24 19:45:13 UTC</Created>
  <Updated>2009-11-24 20:16:19 UTC</Updated>
  <Language>it</Language>
  <Format>ppt</Format>
  <Download>1</Download>
  <DownloadUrl>http://s3.amazonaws.com/ppt-download/trovareslideshare-091124134526-phpapp02.ppt?response-content-disposition=attachment&amp;Signature=MbUlTU%2BbpDwMFx%2B5v2aCGQxSzCo%3D&amp;Expires=1389134793&amp;AWSAccessKeyId=AKIAIW74DRRRQSO4NIKA</DownloadUrl>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>10366734</ID>
  <Title>The Social Content Quiet Giant</Title>
  <Description>This presentation comes from an infographic produced in collaboration with ColumnFive. The infographic is here: http://www.slideshare.net/slidesharepro/slideshare-infographic-the-quiet-giant-of-content-marketing Sources of data for this presentation: B2B Technology Marketing Community on LinkedIn, The Content Marketing Institute, SlideShare Zeigeist, Quantcast and Comscore.
</Description>
  <Status>2</Status>
  <Username>slidesharepro</Username>
  <URL>http://www.slideshare.net/slidesharepro/the-social-content-quiet-giant</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/slideshareinfographicpreso-111128083427-phpapp02-thumbnail.jpg?cb=1365672261</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/slideshareinfographicpreso-111128083427-phpapp02-thumbnail-2.jpg?cb=1365672261</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/10366734&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/slidesharepro/the-social-content-quiet-giant&quot; title=&quot;The Social Content Quiet Giant&quot; target=&quot;_blank&quot;&gt;The Social Content Quiet Giant&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/slidesharepro&quot; target=&quot;_blank&quot;&gt;SlideShare Content Marketing&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2011-11-28 14:34:26 UTC</Created>
  <Updated>2013-04-11 09:24:21 UTC</Updated>
  <Language>en</Language>
  <Format>pptx</Format>
  <Download>1</Download>
  <DownloadUrl>http://s3.amazonaws.com/ppt-download/slideshareinfographicpreso-111128083427-phpapp02.pptx?response-content-disposition=attachment&amp;Signature=shwbCO69m3yB%2FoTYNdixCdWbGsw%3D&amp;Expires=1389134793&amp;AWSAccessKeyId=AKIAIW74DRRRQSO4NIKA</DownloadUrl>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>219627</ID>
  <Title>Branding 2.0 &amp;amp; Social Media</Title>
  <Description>Branding in the new era has shifted to more engagement orientated due to the advent of Web 2.0 and Social Media.The presentation aims at how, where and when aspects of it...</Description>
  <Status>2</Status>
  <Username>sampad.s</Username>
  <URL>http://www.slideshare.net/sampad.s/branding-20-social-media</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/branding-20-social-media-1199605191511358-2-thumbnail.jpg?cb=1339767349</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/branding-20-social-media-1199605191511358-2-thumbnail-2.jpg?cb=1339767349</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/219627&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/sampad.s/branding-20-social-media&quot; title=&quot;Branding 2.0 &amp;amp; Social Media&quot; target=&quot;_blank&quot;&gt;Branding 2.0 &amp;amp; Social Media&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/sampad.s&quot; target=&quot;_blank&quot;&gt;Sampad Swain&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2008-01-06 05:39:54 UTC</Created>
  <Updated>2012-06-15 13:35:49 UTC</Updated>
  <Language>en</Language>
  <Format>ppt</Format>
  <Download>0</Download>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>3820856</ID>
  <Title>How to use SlideShare to promote your business (webinar)</Title>
  <Description>
</Description>
  <Status>2</Status>
  <Username>rashmi</Username>
  <URL>http://www.slideshare.net/rashmi/slide-share-business-final</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/slidesharebusinessfinal-100422141910-phpapp02-thumbnail.jpg?cb=1273969810</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/slidesharebusinessfinal-100422141910-phpapp02-thumbnail-2.jpg?cb=1273969810</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/3820856&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/rashmi/slide-share-business-final&quot; title=&quot;How to use SlideShare to promote your business (webinar)&quot; target=&quot;_blank&quot;&gt;How to use SlideShare to promote your business (webinar)&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/rashmi&quot; target=&quot;_blank&quot;&gt;Rashmi Sinha&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2010-04-22 19:19:04 UTC</Created>
  <Updated>2010-05-16 00:30:10 UTC</Updated>
  <Language>en</Language>
  <Format>ppt</Format>
  <Download>1</Download>
  <DownloadUrl>http://s3.amazonaws.com/ppt-download/slidesharebusinessfinal-100422141910-phpapp02.ppt?response-content-disposition=attachment&amp;Signature=YfufoDuoR4MW7wAfbQztOPAgHL4%3D&amp;Expires=1389134793&amp;AWSAccessKeyId=AKIAIW74DRRRQSO4NIKA</DownloadUrl>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>4459108</ID>
  <Title>Slideshare</Title>
  <Description>http://www.bethkanter.org/nine-ways-networked-nonprofits-use-slideshare/</Description>
  <Status>2</Status>
  <Username>kanter</Username>
  <URL>http://www.slideshare.net/kanter/slideshare-4459108</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/slideshare-100610004421-phpapp02-thumbnail.jpg?cb=1276203362</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/slideshare-100610004421-phpapp02-thumbnail-2.jpg?cb=1276203362</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/4459108&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/kanter/slideshare-4459108&quot; title=&quot;Slideshare&quot; target=&quot;_blank&quot;&gt;Slideshare&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/kanter&quot; target=&quot;_blank&quot;&gt;Beth Kanter&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2010-06-10 05:44:20 UTC</Created>
  <Updated>2010-06-10 20:56:02 UTC</Updated>
  <Language>en</Language>
  <Format>pptx</Format>
  <Download>0</Download>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>13995065</ID>
  <Title>10 Proven Tips for Leveraging Slideshare</Title>
  <Description>Slideshare continues to be a compelling visual medium for marketers everywhere, but people don&amp;rsquo;t realize that there are tips and tricks to ensuring you&amp;rsquo;re squeezing the most out of the presentations that you post on Slideshare. Learn how to get around the import limitations of Slideshare and how to even embed links in your presentations for maximum exposure.  These are the top 10 proven tips for leveraging Slideshare that I&amp;rsquo;ve learned over the years and that have driven hundreds of leads to my clients.</Description>
  <Status>2</Status>
  <Username>douglaskarr</Username>
  <URL>http://www.slideshare.net/douglaskarr/10-proven-tips-for-leveraging-slideshare</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/slideshare-tips-120816232709-phpapp02-thumbnail.jpg?cb=1345474261</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/slideshare-tips-120816232709-phpapp02-thumbnail-2.jpg?cb=1345474261</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/13995065&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/douglaskarr/10-proven-tips-for-leveraging-slideshare&quot; title=&quot;10 Proven Tips for Leveraging Slideshare&quot; target=&quot;_blank&quot;&gt;10 Proven Tips for Leveraging Slideshare&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/douglaskarr&quot; target=&quot;_blank&quot;&gt;Douglas Karr&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2012-08-17 04:27:06 UTC</Created>
  <Updated>2012-08-20 14:51:01 UTC</Updated>
  <Language>en</Language>
  <Format>pptx</Format>
  <Download>0</Download>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>4723483</ID>
  <Title>Fonts in Slideshare</Title>
  <Description>Which fonts can you use with Slideshare when don&amp;rsquo;t want to convert your presentation into a pdf?

This presentation show how 144 fonts look like on Slideshare.

Made with Apple Keynote and uploaded as a zip file.

</Description>
  <Status>2</Status>
  <Username>typofi</Username>
  <URL>http://www.slideshare.net/typofi/fonts-in-slideshare</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/font-test-100709183838-phpapp02-thumbnail.jpg?cb=1279525283</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/font-test-100709183838-phpapp02-thumbnail-2.jpg?cb=1279525283</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/4723483&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/typofi/fonts-in-slideshare&quot; title=&quot;Fonts in Slideshare&quot; target=&quot;_blank&quot;&gt;Fonts in Slideshare&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/typofi&quot; target=&quot;_blank&quot;&gt;Jasso Lamberg&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2010-07-09 23:38:30 UTC</Created>
  <Updated>2010-07-19 07:41:23 UTC</Updated>
  <Language>en</Language>
  <Format>zip</Format>
  <Download>0</Download>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>6809473</ID>
  <Title>Tutorial slideshare 2011</Title>
  <Description>Tutorial actualizado sobre el uso de slideshare</Description>
  <Status>2</Status>
  <Username>airomanos</Username>
  <URL>http://www.slideshare.net/airomanos/tutorial-slideshare-2011</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/tutorialslideshare-110204054403-phpapp02-thumbnail.jpg?cb=1297762576</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/tutorialslideshare-110204054403-phpapp02-thumbnail-2.jpg?cb=1297762576</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/6809473&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/airomanos/tutorial-slideshare-2011&quot; title=&quot;Tutorial slideshare 2011&quot; target=&quot;_blank&quot;&gt;Tutorial slideshare 2011&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/airomanos&quot; target=&quot;_blank&quot;&gt;Ana Romano&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2011-02-04 11:43:57 UTC</Created>
  <Updated>2011-02-15 09:36:16 UTC</Updated>
  <Language>es</Language>
  <Format>ppt</Format>
  <Download>1</Download>
  <DownloadUrl>http://s3.amazonaws.com/ppt-download/tutorialslideshare-110204054403-phpapp02.ppt?response-content-disposition=attachment&amp;Signature=Hur2K3JUtb7YD9mpsCYzbrs7xEs%3D&amp;Expires=1389134793&amp;AWSAccessKeyId=AKIAIW74DRRRQSO4NIKA</DownloadUrl>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>14239663</ID>
  <Title>Scoop those slides!</Title>
  <Description>Curate SlideShare Content with Scoop.it!

Presentations work great for Curators but Curators are also great for Presentations. Whether you&amp;rsquo;re using SlideShare to upload your presentations or using Scoop.it to curate your favorite topic, learn how the new Scoop.it / SlideShare integration can help you better leverage your publishing activity.

And try it out by visiting http://scoop.it !</Description>
  <Status>2</Status>
  <Username>Scoopit</Username>
  <URL>http://www.slideshare.net/Scoopit/scoop-those-slides</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/scoopthoseslides-120910151856-phpapp02-thumbnail.jpg?cb=1347379462</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/scoopthoseslides-120910151856-phpapp02-thumbnail-2.jpg?cb=1347379462</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/14239663&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/Scoopit/scoop-those-slides&quot; title=&quot;Scoop those slides!&quot; target=&quot;_blank&quot;&gt;Scoop those slides!&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/Scoopit&quot; target=&quot;_blank&quot;&gt;Scoop.it&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2012-09-10 20:18:55 UTC</Created>
  <Updated>2012-09-11 16:04:22 UTC</Updated>
  <Language>en</Language>
  <Format>pptx</Format>
  <Download>1</Download>
  <DownloadUrl>http://s3.amazonaws.com/ppt-download/scoopthoseslides-120910151856-phpapp02.pptx?response-content-disposition=attachment&amp;Signature=evwWXpUVzRDHHV654lDLFpCuRM0%3D&amp;Expires=1389134793&amp;AWSAccessKeyId=AKIAIW74DRRRQSO4NIKA</DownloadUrl>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>4466661</ID>
  <Title>Slide share nonprofit_gov_agencies</Title>
  <Description>
</Description>
  <Status>2</Status>
  <Username>rashmi</Username>
  <URL>http://www.slideshare.net/rashmi/slide-share-nonprofitgovagencies</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/slidesharenonprofitgovagencies-100610123312-phpapp02-thumbnail.jpg?cb=1276191285</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/slidesharenonprofitgovagencies-100610123312-phpapp02-thumbnail-2.jpg?cb=1276191285</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/4466661&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/rashmi/slide-share-nonprofitgovagencies&quot; title=&quot;Slide share nonprofit_gov_agencies&quot; target=&quot;_blank&quot;&gt;Slide share nonprofit_gov_agencies&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/rashmi&quot; target=&quot;_blank&quot;&gt;Rashmi Sinha&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2010-06-10 17:33:04 UTC</Created>
  <Updated>2010-06-10 17:34:45 UTC</Updated>
  <Language>en</Language>
  <Format>ppt</Format>
  <Download>1</Download>
  <DownloadUrl>http://s3.amazonaws.com/ppt-download/slidesharenonprofitgovagencies-100610123312-phpapp02.ppt?response-content-disposition=attachment&amp;Signature=2byEU4BquIF9%2BEoCuzmpK4MWjXc%3D&amp;Expires=1389134793&amp;AWSAccessKeyId=AKIAIW74DRRRQSO4NIKA</DownloadUrl>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>3981562</ID>
  <Title>Work wants to be social (talk at Web 2 Expo 2010)</Title>
  <Description>
</Description>
  <Status>2</Status>
  <Username>rashmi</Username>
  <URL>http://www.slideshare.net/rashmi/work-wants-to-be-social</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/rashmisinha169-100505151534-phpapp01-thumbnail.jpg?cb=1273977535</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/rashmisinha169-100505151534-phpapp01-thumbnail-2.jpg?cb=1273977535</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/3981562&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/rashmi/work-wants-to-be-social&quot; title=&quot;Work wants to be social (talk at Web 2 Expo 2010)&quot; target=&quot;_blank&quot;&gt;Work wants to be social (talk at Web 2 Expo 2010)&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/rashmi&quot; target=&quot;_blank&quot;&gt;Rashmi Sinha&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2010-05-05 20:15:26 UTC</Created>
  <Updated>2010-05-16 02:38:55 UTC</Updated>
  <Language>en</Language>
  <Format>ppt</Format>
  <Download>1</Download>
  <DownloadUrl>http://s3.amazonaws.com/ppt-download/rashmisinha169-100505151534-phpapp01.ppt?response-content-disposition=attachment&amp;Signature=2Epcw54a2xGeO88yr7x0nz4enlE%3D&amp;Expires=1389134793&amp;AWSAccessKeyId=AKIAIW74DRRRQSO4NIKA</DownloadUrl>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>958429</ID>
  <Title>Redes Sociais</Title>
  <Description>Keynote da apresenta&#231;&#227;o sobre Redes Sociais no Grupo Tom de Estudos do dia 27 de janeiro de 2007. Palestrante: Guilherme Boechat.</Description>
  <Status>2</Status>
  <Username>tomcomunicacao</Username>
  <URL>http://www.slideshare.net/tomcomunicacao/redes-sociais-presentation-958429</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/redes-sociais-slideshare-1233084012104049-1-thumbnail.jpg?cb=1331218767</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/redes-sociais-slideshare-1233084012104049-1-thumbnail-2.jpg?cb=1331218767</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/958429&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/tomcomunicacao/redes-sociais-presentation-958429&quot; title=&quot;Redes Sociais&quot; target=&quot;_blank&quot;&gt;Redes Sociais&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/tomcomunicacao&quot; target=&quot;_blank&quot;&gt;Tom Comunica&#231;&#227;o&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2009-01-27 19:20:12 UTC</Created>
  <Updated>2012-03-08 14:59:27 UTC</Updated>
  <Language>pt</Language>
  <Format>pdf</Format>
  <Download>1</Download>
  <DownloadUrl>http://s3.amazonaws.com/ppt-download/redes-sociais-slideshare-1233084012104049-1.pdf?response-content-disposition=attachment&amp;Signature=u%2BCCpoo1ZNzXI5M6VSNgKtqh%2FEk%3D&amp;Expires=1389134793&amp;AWSAccessKeyId=AKIAIW74DRRRQSO4NIKA</DownloadUrl>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>1176192</ID>
  <Title>Real World Examples of Succesful Enterprise Content Management Strategies</Title>
  <Description>Presentations based partly on information Andy and I pulled together for our book, and partly from the Oracle &amp;quot;Survive or Thrive&amp;quot; webcasts.</Description>
  <Status>2</Status>
  <Username>bexmex</Username>
  <URL>http://www.slideshare.net/bexmex/real-world-examples-of-succesful-enterprise-content-management-strategies</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/real-world-examples-of-ecm-strategy-slideshare-090320165826-phpapp01-thumbnail.jpg?cb=1237586337</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/real-world-examples-of-ecm-strategy-slideshare-090320165826-phpapp01-thumbnail-2.jpg?cb=1237586337</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/1176192&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/bexmex/real-world-examples-of-succesful-enterprise-content-management-strategies&quot; title=&quot;Real World Examples of Succesful Enterprise Content Management Strategies&quot; target=&quot;_blank&quot;&gt;Real World Examples of Succesful Enterprise Content Management Strategies&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/bexmex&quot; target=&quot;_blank&quot;&gt;Brian Huff&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2009-03-20 21:58:23 UTC</Created>
  <Updated>2009-03-20 21:58:57 UTC</Updated>
  <Language>en</Language>
  <Format>ppt</Format>
  <Download>1</Download>
  <DownloadUrl>http://s3.amazonaws.com/ppt-download/real-world-examples-of-ecm-strategy-slideshare-090320165826-phpapp01.ppt?response-content-disposition=attachment&amp;Signature=zi408RuOtJvzxPIlB7sbdNaKM9Q%3D&amp;Expires=1389134793&amp;AWSAccessKeyId=AKIAIW74DRRRQSO4NIKA</DownloadUrl>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
<Slideshow>
  <ID>1087717</ID>
  <Title>Why Agile Works But Isn&amp;rsquo;t Working For You</Title>
  <Description>Presentation for Causerie at ADMB Bruges, Thursday 12 February 2009.

Audio will be added once I have it - the pictures are nice, but I&amp;rsquo;m not sure they make that much sense without the narrative (or do they? What do you think?)

(NB first slide is not a mistake - deliberately empty)</Description>
  <Status>2</Status>
  <Username>davethehat</Username>
  <URL>http://www.slideshare.net/davethehat/why-agile-works-but-isnt-working-for-you-1087717</URL>
  <ThumbnailURL>//cdn.slidesharecdn.com/ss_thumbnails/whyagileworksbutisntworkingforyou-090301153429-phpapp01-thumbnail.jpg?cb=1236006154</ThumbnailURL>
  <ThumbnailSize>[170,130]</ThumbnailSize>
  <ThumbnailSmallURL>//cdn.slidesharecdn.com/ss_thumbnails/whyagileworksbutisntworkingforyou-090301153429-phpapp01-thumbnail-2.jpg?cb=1236006154</ThumbnailSmallURL>
  <Embed>&lt;iframe src=&quot;https://www.slideshare.net/slideshow/embed_code/1087717&quot; width=&quot;427&quot; height=&quot;356&quot; frameborder=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot; scrolling=&quot;no&quot; style=&quot;border:1px solid #CCC;border-width:1px 1px 0;margin-bottom:5px&quot; allowfullscreen&gt; &lt;/iframe&gt; &lt;div style=&quot;margin-bottom:5px&quot;&gt; &lt;strong&gt; &lt;a href=&quot;https://www.slideshare.net/davethehat/why-agile-works-but-isnt-working-for-you-1087717&quot; title=&quot;Why Agile Works But Isn&amp;#x27;t Working For You&quot; target=&quot;_blank&quot;&gt;Why Agile Works But Isn&amp;#x27;t Working For You&lt;/a&gt; &lt;/strong&gt; from &lt;strong&gt;&lt;a href=&quot;http://www.slideshare.net/davethehat&quot; target=&quot;_blank&quot;&gt;David Harvey&lt;/a&gt;&lt;/strong&gt; &lt;/div&gt;

</Embed>
  <Created>2009-03-01 21:34:26 UTC</Created>
  <Updated>2009-03-02 15:02:34 UTC</Updated>
  <Language>en</Language>
  <Format>pdf</Format>
  <Download>0</Download>
  <SlideshowType>0</SlideshowType>
  <InContest>0</InContest>
</Slideshow>
</Slideshows>";

    #endregion

        [TestMethod]
        public void Can_Create_XmlSerializer_And_Deserialize()
        {
            /*
             * Needed to work out Slideshow serialization.
             * 
             */
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Slideshows));

            Assert.IsNotNull(serializer);

            Slideshows shows = (Slideshows)serializer.Deserialize(new StringReader( _sampleSlideshows));

            Assert.IsNotNull(shows);
        }

        [TestMethod]
        public void Can_Search_With_Term()
        {
            /*
             * Needed to work out command errors (https vs http).
             */
            var slideshare = new SlideShare(_apiKey, _secret);

            var shows = slideshare.SlideshowSearch("social media", 1, 25, "en", SortOrder.relevance);

            Assert.IsNotNull(shows);

        }
    }
}
