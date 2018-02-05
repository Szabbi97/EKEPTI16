DECLARE
   v_nls_param   VARCHAR2(20);
   v_sql         VARCHAR2(200);
   v_nls_charset VARCHAR2(200) :='NLS_NCHAR_CHARACTERSET';
BEGIN 
  v_sql := 'SELECT VALUE FROM nls_database_parameters WHERE PARAMETER=:1';
  EXECUTE IMMEDIATE v_sql INTO v_nls_param USING v_nls_charset;
  IF ( v_nls_param in ('AL32UTF8', 'UTF8', 'AL16UTF16') ) THEN
insert into ODMR$MESSAGES(message_id,language_id,message) values (1, 'zh-TW', UNISTR('\007b\0031\007d\0020\007b\0032\007d\0020\4e0d\5b58\5728\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (2, 'zh-TW', UNISTR('\007b\0031\007d\0020\007b\0032\007d\0020\5df2\7d93\5b58\5728\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (3, 'zh-TW', UNISTR('\7531\65bc\0020\007b\0032\007d\002c\0020\007b\0031\007d\0020\5931\6557\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (4, 'zh-TW', UNISTR('\7121\6548\7684\8f38\5165\003a\0020\007b\0031\007d\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (5, 'zh-TW', UNISTR('\6b64\7bc0\9ede\7684\8f38\5165\4f86\6e90\672a\5305\542b\8cc7\6599\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (6, 'zh-TW', UNISTR('\7bc0\9ede\7522\751f\7a7a\767d\7684\8f38\51fa\7d50\679c\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (7, 'zh-TW', UNISTR('\7121\6548\7684\6210\672c\6548\76ca\77e9\9663\003a\0020\007b\0031\007d\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (8, 'zh-TW', UNISTR('\76ee\6a19\0020\007b\0031\007d\0020\53ea\5305\542b\4e00\500b\76f8\7570\503c\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (9, 'zh-TW', UNISTR('\76ee\6a19\0020\007b\0031\007d\0020\8d85\904e\76f8\7570\503c\4e0a\9650\002e\0020\5141\8a31\0020\7684\76f8\7570\503c\6578\76ee\4e0a\9650\70ba\0020\007b\0032\007d\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (10, 'zh-TW', UNISTR('\76ee\6a19\0020\007b\0031\007d\0020\5305\542b\552f\4e00\503c\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (11, 'zh-TW', UNISTR('\76ee\6a19\0020\007b\0031\007d\0020\5305\542b\0020\004e\0055\004c\004c\0020\503c\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (12, 'zh-TW', UNISTR('\76ee\6a19\0020\007b\0031\007d\0020\5305\542b\5168\90e8\70ba\7a7a\683c\7684\503c\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (13, 'zh-TW', UNISTR('\76ee\6a19\0020\007b\0031\007d\0020\5305\542b\5168\90e8\70ba\0020\004e\0055\004c\004c\0020\7684\503c\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (14, 'zh-TW', UNISTR('\8cc7\6599\985e\578b\0020\007b\0032\007d\0020\7684\76ee\6a19\0020\007b\0031\007d\0020\53ef\80fd\8207\0020\007b\0033\007d\0020\4e0d\76f8\5bb9\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (15, 'zh-TW', UNISTR('\76ee\6a19\0020\007b\0031\007d\0020\5305\542b\4e0d\76f8\5bb9\65bc\73fe\6709\6a21\578b\7684\0020\503c\0020\007b\0032\007d\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (16, 'zh-TW', UNISTR('\542b\6709\4e0d\76f8\5bb9\8cc7\6599\985e\578b\0020\007b\0032\007d\0020\7684\76ee\6a19\0020\007b\0031\007d\0020\0028\53ea\5141\8a31\0020\0056\0041\0052\0043\0048\0041\0052\0032\3001\0043\0048\0041\0052\3001\004e\0055\004d\0042\0045\0052\0020\6216\0020\0046\004c\004f\0041\0054\0029\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (17, 'zh-TW', UNISTR('\6848\4f8b\0020\0049\0044\0020\007b\0031\007d\0020\672a\5305\542b\552f\4e00\503c\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (18, 'zh-TW', UNISTR('\907a\6f0f\0020\007b\0031\007d\0020\007b\0032\007d\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (19, 'zh-TW', UNISTR('\007b\0031\007d\0020\007b\0032\007d\0020\6709\592a\591a\76f8\7570\503c\002e\0020\5141\8a31\0020\7684\76f8\7570\503c\6578\76ee\4e0a\9650\70ba\0020\007b\0033\007d') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (20, 'zh-TW', UNISTR('\0047\004c\004d\0020\53ea\63a5\53d7\4e8c\9032\4f4d\76ee\6a19\8a2d\5b9a\0020\0028\5169\500b\0020\503c\0029\002e\0020\9078\53d6\7684\76ee\6a19\0020\007b\0031\007d\0020\5305\542b\5169\500b\0020\4ee5\4e0a\7684\503c\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (21, 'zh-TW', UNISTR('\7121\6548\7684\5957\7528\5c6c\6027\003a\0020\007b\0031\007d\002e\0020\5c6c\6027\5177\6709\0020\8cc7\6599\985e\578b\0020\007b\0032\007d\002c\0020\4f46\662f\7528\4f86\5efa\7acb\6a21\578b\0020\007b\0033\007d\0020\7684\5c6c\6027\5177\6709\8cc7\6599\985e\578b\0020\007b\0034\007d\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (22, 'zh-TW', UNISTR('\5de5\4f5c\6d41\7a0b\57f7\884c\5df2\7531\4f7f\7528\8005\53d6\6d88\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (23, 'zh-TW', UNISTR('\5de5\4f5c\6d41\7a0b\672a\57f7\884c\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (24, 'zh-TW', UNISTR('\6c92\6709\70ba\8cc7\6599\6b04\0020\007b\0031\007d\0020\7522\751f\4e3b\984c\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (25, 'zh-TW', UNISTR('\6a21\578b\7d44\5efa\7684\8a13\7df4\8cc7\6599\7121\6548\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (26, 'zh-TW', UNISTR('\542b\4e0d\76f8\5bb9\8cc7\6599\985e\578b\0020\007b\0032\007d\0020\7684\8f38\5165\8cc7\6599\6b04\0020\007b\0031\007d\0020\0028\53ea\5141\8a31\0020\0056\0041\0052\0043\0048\0041\0052\0032\3001\0043\0048\0041\0052\3001\004e\0055\004d\0042\0045\0052\0020\6216\0020\0046\004c\004f\0041\0054\0029\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (27, 'zh-TW', UNISTR('\542b\4e0d\76f8\5bb9\8cc7\6599\985e\578b\0020\007b\0032\007d\0020\7684\8f38\5165\8cc7\6599\6b04\0020\007b\0031\007d\0020\0028\53ea\5141\8a31\0020\0056\0041\0052\0043\0048\0041\0052\0032\3001\0043\0048\0041\0052\3001\004e\0055\004d\0042\0045\0052\3001\0046\004c\004f\0041\0054\3001\0044\004d\005f\004e\0045\0053\0054\0045\0044\005f\004e\0055\004d\0045\0052\0049\0043\0041\004c\0053\0020\6216\0020\0044\004d\005f\004e\0045\0053\0054\0045\0044\005f\0043\0041\0054\0045\0047\004f\0052\0049\0043\0041\004c\0053\0029\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (28, 'zh-TW', UNISTR('\907a\6f0f\6587\5b57\8f49\63db\6240\4f7f\7528\7684\0020\007b\0031\007d\0020\007b\0032\007d\002e\0020\57f7\884c\5c0d\61c9\7684\300c\7d44\5efa\6587\5b57\300d\7bc0\9ede\4ee5\91cd\65b0\5efa\7acb\0020\007b\0031\007d\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (29, 'zh-TW', UNISTR('\7531\65bc\5305\542b\7684\5de5\4f5c\6d41\7a0b\5728\4e0d\540c\7684\968e\6bb5\4f5c\696d\4f7f\7528\6216\0020\6b63\5728\57f7\884c\4e2d\002c\0020\56e0\6b64\7121\6cd5\522a\9664\5c08\6848\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (30, 'zh-TW', UNISTR('\672a\5c07\300c\8868\683c\300d\6216\300c\8996\89c0\8868\300d\76f4\63a5\6388\6b0a\7d66\76ee\524d\7684\4f7f\7528\8005\002e\0020\9019\6703\5c0e\81f4\0020\0044\0061\0074\0061\0020\004d\0069\006e\0065\0072\0020\5617\8a66\5efa\7acb\8996\89c0\8868\6642\5931\6557\002e\0020\8868\683c\002f\8996\89c0\8868\003a\0020\007b\0031\007d\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (31, 'zh-TW', UNISTR('\5de5\4f5c\6d41\7a0b\5931\6557\002c\0020\539f\56e0\662f\4e0b\5217\7bc0\9ede\767c\751f\975e\9810\671f\5931\6557\002e\0020\8acb\6aa2\67e5\662f\5426\6709\4efb\4f55\7522\751f\7684\6838\5fc3\50be\5370\003a\0020\007b\0031\007d\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (32, 'zh-TW', UNISTR('\76ee\6a19\0020\007b\0031\007d\0020\5177\6709\4e0d\76f8\5bb9\7684\8cc7\6599\985e\578b\0020\007b\0032\007d\0020\0028\50c5\5141\8a31\0020\0056\0041\0052\0043\0048\0041\0052\0032\3001\0043\0048\0041\0052\3001\004e\0055\004d\0042\0045\0052\3001\0046\004c\004f\0041\0054\3001\0042\0049\004e\0041\0052\0059\005f\0044\004f\0055\0042\004c\0045\0020\6216\0020\0042\0049\004e\0041\0052\0059\005f\0046\004c\004f\0041\0054\0029\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (33, 'zh-TW', UNISTR('\76ee\6a19\0020\007b\0031\007d\0020\5177\6709\4e0d\76f8\5bb9\7684\6578\503c\8cc7\6599\985e\578b\0020\007b\0032\007d\0020\0028\50c5\5141\8a31\0020\004e\0055\004d\0042\0045\0052\0020\6216\0020\0046\004c\004f\0041\0054\0029\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (34, 'zh-TW', UNISTR('\76ee\6a19\0020\007b\0031\007d\0020\5177\6709\4e0d\76f8\5bb9\7684\6578\503c\8cc7\6599\985e\578b\0020\007b\0032\007d\0020\0028\50c5\5141\8a31\0020\004e\0055\004d\0042\0045\0052\3001\0046\004c\004f\0041\0054\3001\0042\0049\004e\0041\0052\0059\005f\0044\004f\0055\0042\004c\0045\0020\6216\0020\0042\0049\004e\0041\0052\0059\005f\0046\004c\004f\0041\0054\0029\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (35, 'zh-TW', UNISTR('\532f\5165\5de5\4f5c\6d41\7a0b\7248\672c\0020\007b\0031\007d\0020\548c\5132\5b58\5340\57df\4e0d\76f8\5bb9\002e\0020\532f\5165\5df2\4e2d\6b62\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1000, 'zh-TW', UNISTR('\8cc7\6599\4f86\6e90') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1001, 'zh-TW', UNISTR('\5de5\4f5c\6d41\7a0b') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1002, 'zh-TW', UNISTR('\5206\4f4d\6578\5206\5340') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1003, 'zh-TW', UNISTR('\5176\4e2d\4e00\500b\8cc7\6599\6b04\7684\8cc7\6599\4e0d\8db3') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1004, 'zh-TW', UNISTR('\9a57\8b49\9577\689d') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1005, 'zh-TW', UNISTR('\8cc7\6599\7684\76f8\7570\503c\4e0d\8db3') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1006, 'zh-TW', UNISTR('\8868\683c') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1007, 'zh-TW', UNISTR('\9a57\8b49') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1008, 'zh-TW', UNISTR('\907a\6f0f\8868\683c\003a') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1009, 'zh-TW', UNISTR('\5c6c\6027') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1010, 'zh-TW', UNISTR('\907a\6f0f\5c6c\6027') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1011, 'zh-TW', UNISTR('\805a\7e3d') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1012, 'zh-TW', UNISTR('\66f4\65b0\8868\683c') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1013, 'zh-TW', UNISTR('\8f38\5165\4e0d\6b63\78ba') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1014, 'zh-TW', UNISTR('\8996\89c0\8868') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1015, 'zh-TW', UNISTR('\5efa\7acb\8868\683c\6216\8996\89c0\8868') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1016, 'zh-TW', UNISTR('\700f\89bd\8cc7\6599') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1017, 'zh-TW', UNISTR('\7d44\5efa') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1018, 'zh-TW', UNISTR('\6e2c\8a66') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1019, 'zh-TW', UNISTR('\8f38\5165\8cc7\6599\7a7a\767d') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1020, 'zh-TW', UNISTR('\76ee\6a19') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1021, 'zh-TW', UNISTR('\5c6c\6027') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1022, 'zh-TW', UNISTR('\4e0d\76f8\5bb9\7684\8f38\5165\002f\76ee\6a19\002f\6848\4f8b\0020\0049\0044\0020\5c6c\6027') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1023, 'zh-TW', UNISTR('\6a21\578b') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1024, 'zh-TW', UNISTR('\907a\6f0f\6a21\578b') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1025, 'zh-TW', UNISTR('\0047\004c\004d\0020\53ea\63a5\53d7\4e8c\9032\4f4d\76ee\6a19\8a2d\5b9a\0020\0028\5169\500b\503c\0029\002e\0020\9078\53d6\7684\76ee\6a19\5305\542b\5169\500b\4ee5\4e0a\7684\503c\002e') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1026, 'zh-TW', UNISTR('\7121\6548\7684\9805\76ee\503c\5c6c\6027') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1027, 'zh-TW', UNISTR('\907a\6f0f\6a21\578b') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1028, 'zh-TW', UNISTR('\5957\7528') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1029, 'zh-TW', UNISTR('\672a\57f7\884c\9a57\8b49') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1030, 'zh-TW', UNISTR('\6a21\578b\8a73\7d30\8cc7\8a0a') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1031, 'zh-TW', UNISTR('\6e2c\8a66\8a73\7d30\8cc7\8a0a') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1032, 'zh-TW', UNISTR('\7be9\9078\8a73\7d30\8cc7\8a0a') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1033, 'zh-TW', UNISTR('\7279\5fb5\8868\683c') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1034, 'zh-TW', UNISTR('\539f\5247') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1035, 'zh-TW', UNISTR('\8a5e\5f59\5206\6790\7a0b\5f0f') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1036, 'zh-TW', UNISTR('\505c\7528\5b57\8a5e\8868') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1037, 'zh-TW', UNISTR('\4e0d\76f8\5bb9\7684\6848\4f8b\0020\0049\0044\0020\5c6c\6027') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1038, 'zh-TW', UNISTR('\8cc7\6599\6b04') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1039, 'zh-TW', UNISTR('\4e0d\76f8\5bb9\7684\8cc7\6599\6b04\5c6c\6027') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1040, 'zh-TW', UNISTR('\7d50\5408') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1041, 'zh-TW', UNISTR('\6587\5b57') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1042, 'zh-TW', UNISTR('\5206\5272') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1043, 'zh-TW', UNISTR('\8cc7\6599\6b04') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1044, 'zh-TW', UNISTR('\6a23\672c') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1045, 'zh-TW', UNISTR('\8cc7\6599\6b04\7be9\9078') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1046, 'zh-TW', UNISTR('\8cc7\6599\5217\7be9\9078') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1047, 'zh-TW', UNISTR('\8f49\63db') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1048, 'zh-TW', UNISTR('\5de5\4f5c\6d41\7a0b\5132\5b58') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1049, 'zh-TW', UNISTR('\4f7f\7528\8005\6c92\6709\9396\5b9a\5de5\4f5c\6d41\7a0b') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1050, 'zh-TW', UNISTR('\5de5\4f5c\6d41\7a0b\57f7\884c') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1051, 'zh-TW', UNISTR('\5de5\4f5c\6d41\7a0b\5df2\5728\57f7\884c\4e2d') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1052, 'zh-TW', UNISTR('\5176\4ed6\4f7f\7528\8005\6b63\5728\4f7f\7528\5de5\4f5c\6d41\7a0b\002c\0020\6216\5de5\4f5c\6d41\7a0b\6b63\5728\57f7\884c\4e2d') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1053, 'zh-TW', UNISTR('\5de5\4f5c\6d41\7a0b\522a\9664') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1054, 'zh-TW', UNISTR('\56de\6b78\7d44\5efa') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1055, 'zh-TW', UNISTR('\5206\985e\7d44\5efa') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1056, 'zh-TW', UNISTR('\7d44\5efa\6587\5b57') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1057, 'zh-TW', UNISTR('\5957\7528\6587\5b57') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1058, 'zh-TW', UNISTR('\7d44\5efa\6587\5b57\53c3\7167') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1059, 'zh-TW', UNISTR('\9805\76ee\503c') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1060, 'zh-TW', UNISTR('\5c08\6848') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1061, 'zh-TW', UNISTR('\5de5\4f5c\6d41\7a0b\91cd\65b0\547d\540d') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1062, 'zh-TW', UNISTR('\5de5\4f5c\6d41\7a0b\5b9a\7fa9\7121\6548') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1063, 'zh-TW', UNISTR('\958b\59cb') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1064, 'zh-TW', UNISTR('\7d50\675f') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1065, 'zh-TW', UNISTR('\5de5\4f5c\6d41\7a0b') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1066, 'zh-TW', UNISTR('\7bc0\9ede') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1067, 'zh-TW', UNISTR('\5b50\7bc0\9ede') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1068, 'zh-TW', UNISTR('\9a57\8b49') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1069, 'zh-TW', UNISTR('\6a23\672c') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1070, 'zh-TW', UNISTR('\5feb\53d6') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1071, 'zh-TW', UNISTR('\7d71\8a08\8cc7\6599') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1072, 'zh-TW', UNISTR('\7279\5fb5') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1073, 'zh-TW', UNISTR('\6e96\5099\8cc7\6599') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1074, 'zh-TW', UNISTR('\7d44\5efa') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1075, 'zh-TW', UNISTR('\6e2c\8a66') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1076, 'zh-TW', UNISTR('\5957\7528') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1077, 'zh-TW', UNISTR('\8f49\63db') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1078, 'zh-TW', UNISTR('\6587\5b57') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1079, 'zh-TW', UNISTR('\0042\0075\0069\006c\0064\0054\0065\0078\0074') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1080, 'zh-TW', UNISTR('\0041\0070\0070\006c\0079\0054\0065\0078\0074') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1081, 'zh-TW', UNISTR('\8f38\51fa') );
insert into ODMR$MESSAGES(message_id,language_id,message) values (1082, 'zh-TW', UNISTR('\6e05\9664') );
  END IF;
END;
/