# ScrapingSpider
> C#������֧�ֶ��̣߳��ؼ��ֹ��ˣ����������Խ���������
> �������ʹ��ҵ��ʱ�俪��

# ���ٿ�ʼ
## Spider�����������
����ĺ���ʵ����ScrapingSpider.Core�����С�������ΪSpider�࣬�������ȡ�߼�����ҳ�洦���߼�ͨ���¼����룬�����ؼ��¼�ΪAddUrlEvent��DataReceivedEvent��

## ����Spider��
```C#
// �������棬��Ҫ3���������������ã�ʵ����ILogger����־��¼�����ϴ�δִ�������ȡ����
Spider spider = new Spider(new Settings(), new EmptyLogger(), null);

spider.AddUrlEvent += addUrlArgs =>
{
	// Url������ӵ����е��¼�����
};

spider.DataReceivedEvent += receivedArgs =>
{
	// ҳ���Ѿ���ץȡ�������¼������ڴ˴���ҳ�棬����ҳ�汣����ӵ����ݿ�
};

// ��ʼ��ȡ
spider.Crawl();
```

## ScrapingSpiderʾ������
* �����ʹ�÷�����ο�ScrapingSpider��Ŀ��Program.cs���е�ʾ�����롣
* ʾ������ʹ��SqlServer���ݿ�洢��ȡ��Ϣ����ṹ��WebPage���Ӧ�����ݿ������ַ�����ο�App.config��
* ����log4net��Ϊ��־��¼�����

## Settings˵��
* Init Seeds: ��ʼUrl��ַ�������ַʹ�ûس��ֿ���
* Regex Filter: ͨ��������ʽ����Url���������ʹ�ûس�������
* Keyword: �ؼ��֣�����ָ���Ĺؼ�����ȡ������ؼ���ʹ�ûس��ֿ���
* Crawl Depth: ��ȡ��ȣ�С��0��ʾ����
* Escape Links: Ҫ���˵����ӣ��磺.jpg|.rar|.exe
* Keep Cookie: ץȡ�������Ƿ���Cookie
* Lock Host: �Ƿ�����Host��������ָץȡվ��������ӡ�
* Limit Speed: �Ƿ��������١�
* Threads: �߳����������ö���߳������������ȡЧ�ʡ�
* Timeout: ��ʱʱ�䣬�Ժ���Ϊ��λ��
* User Agent: httpЭ��UserAgent���á�


# ������־
* 2012/12/25	���Url������ʽ���˹���.
* 2012/12/23	����˵���ĵ���ScrapingSpider��Settings���ڵ�ʹ�ð��������LockHost��Ч�����⣻����ҳ������BUG������Զ����ٹ��ܡ�