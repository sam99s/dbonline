#API Dragon Ball

## SQL SERVER
1) Colocar la cadena de conexion de su base de datos en el archivo appsettings ("cnDbonline")
2) Ejecutar en SQL:

--Dragon Ball--

--Razas--
INSERT INTO raza (RazaNombre) VALUES ('Androides');
INSERT INTO raza (RazaNombre) VALUES ('Animales');
INSERT INTO raza (RazaNombre) VALUES ('Arlianos');
INSERT INTO raza (RazaNombre) VALUES ('Ángeles');
INSERT INTO raza (RazaNombre) VALUES ('Clan de tres ojos');
INSERT INTO raza (RazaNombre) VALUES ('Demonios');
INSERT INTO raza (RazaNombre) VALUES ('Dragones');
INSERT INTO raza (RazaNombre) VALUES ('Dragones Malignos');
INSERT INTO raza (RazaNombre) VALUES ('Dragones Oscuros Xeno');
INSERT INTO raza (RazaNombre) VALUES ('Fantasmas');
INSERT INTO raza (RazaNombre) VALUES ('Genios');
INSERT INTO raza (RazaNombre) VALUES ('Guerreros Fantasmas');
INSERT INTO raza (RazaNombre) VALUES ('Hera');
INSERT INTO raza (RazaNombre) VALUES ('Konatsianos');
INSERT INTO raza (RazaNombre) VALUES ('Kanassanos');
INSERT INTO raza (RazaNombre) VALUES ('Hechicero');
INSERT INTO raza (RazaNombre) VALUES ('Majin');
INSERT INTO raza (RazaNombre) VALUES ('Makyanos');
INSERT INTO raza (RazaNombre) VALUES ('Namekianos');
INSERT INTO raza (RazaNombre) VALUES ('Oni');
INSERT INTO raza (RazaNombre) VALUES ('Raza de Freezer');
INSERT INTO raza (RazaNombre) VALUES ('Terrícolas');
INSERT INTO raza (RazaNombre) VALUES ('Saiyan');
INSERT INTO raza (RazaNombre) VALUES ('Saiyan mestizos (Terrícolas)');
INSERT INTO raza (RazaNombre) VALUES ('Tsufur');
INSERT INTO raza (RazaNombre) VALUES ('Vampiros');
--Series
INSERT INTO serie (SerieNombre) VALUES ('Dragon Ball');
INSERT INTO serie (SerieNombre) VALUES ('Dragon Ball Z');
INSERT INTO serie (SerieNombre) VALUES ('Dragon Ball Super');
INSERT INTO serie (SerieNombre) VALUES ('Dragon Ball GT');
--Sagas
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('Saga de Pilaf', 1, '1986-02-26');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('21° Torneo de las Artes Marciales (Tenkaichi Budōkai)', 1, '1986-02-26');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('Saga del Ejército del Listón rojo (Red Ribbon)', 1, '1986-02-26');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('El Palacio de Uranai Baba', 1, '1986-02-26');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('22° Torneo de las Artes Marciales (Tenkaichi Budōkai)', 1, '1986-02-26');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('Saga de Piccolo Daimaku', 1, '1986-02-26');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('23° Torneo de las Artes Marciales (Tenkaichi Budōkai)', 1, '1986-02-26');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('Preparación para la Boda', 1, '1986-02-26');
--dbz
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('Saga Sayajin', 2, '1989-04-26');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('Saga de Freezer', 2, '1989-04-26');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('Saga de Garlick Jr.', 2, '1989-04-26');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('Saga de Cell', 2, '1989-04-26');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('Saga de Majin Buu', 2, '1989-04-26');
--dbs
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('La Batalla de los Dioses de la destrucción', 3, '2015-07-05');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('La resurrección de Freezer', 3, '2015-07-05');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('El Universo 6 y 7', 3, '2015-07-05');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('Trunks del Futuro - Saga de Goku Black', 3, '2015-07-05');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('El Torneo del Poder', 3, '2015-07-05');
--dbgt
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('El Gran Viaje (En busca de las bolas del dragón de la estrella negra)', 4, '1996-02-07');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('Saga de Baby', 4, '1996-02-07');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('Saga de Súper N.°17', 4, '1996-02-07');
INSERT INTO saga (sagaNombre, serieId, año) VALUES ('Saga de los Dragones Oscuros', 4, '1996-02-07');
--Universos
INSERT INTO universo (UniversoNombre) VALUES ('Universo 1');
INSERT INTO universo (UniversoNombre) VALUES ('Universo 2');
INSERT INTO universo (UniversoNombre) VALUES ('Universo 3');
INSERT INTO universo (UniversoNombre) VALUES ('Universo 4');
INSERT INTO universo (UniversoNombre) VALUES ('Universo 5');
INSERT INTO universo (UniversoNombre) VALUES ('Universo 6');
INSERT INTO universo (UniversoNombre) VALUES ('Universo 7');
INSERT INTO universo (UniversoNombre) VALUES ('Universo 8');
INSERT INTO universo (UniversoNombre) VALUES ('Universo 9');
INSERT INTO universo (UniversoNombre) VALUES ('Universo 10');
INSERT INTO universo (UniversoNombre) VALUES ('Universo 11');
INSERT INTO universo (UniversoNombre) VALUES ('Universo 12');
INSERT INTO universo (UniversoNombre) VALUES ('Universo 13');
--Imagenes
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('426cc89b-54fd-4082-96b4-2faa827f7ed7', 'https://static.wikia.nocookie.net/nuevodragonball/images/3/35/5a0eef099d917.jpeg/revision/latest/scale-to-width-down/1200?cb=20171219152744&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('747db527-c618-4588-8261-8902e2a1b0d2', 'https://static.wikia.nocookie.net/dragonball/images/5/53/EP09DB_Goku_golpea_al_Jefe_Conejo.jpg/revision/latest/scale-to-width-down/250?cb=20160501233723&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('bf2f8ed8-9bf2-4287-ba63-bcd0d64648e1', 'https://static.wikia.nocookie.net/dragonball/images/4/4a/Yamcha_vs_Goku.jpg/revision/latest/scale-to-width-down/250?cb=20100302181124&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('fe1a9f5e-5086-45ca-b5a4-3bc659e6fa50', 'https://static.wikia.nocookie.net/dragonball/images/d/d6/Goku_vs_Luchador_69.png/revision/latest?cb=20130202194858&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('e094ca22-e6b3-49fd-a4a7-e5ce2c7066cb', 'https://static.wikia.nocookie.net/dragonball/images/7/7d/GiranVsGoku.png/revision/latest?cb=20100311032525&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('bb5f3f6b-fc21-4f36-89c9-55c746d04c8a', 'https://i.ytimg.com/vi/4aXBhLKiCGQ/maxresdefault.jpg', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('9f1e1dc5-22f7-4298-bb9a-640a3791fdda', 'https://static.wikia.nocookie.net/dragonball/images/9/9a/Jackie_Chun_vs._Son_Soku_patada.png/revision/latest?cb=20210728165434&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('61bda161-bf00-4aa0-86c4-832b3eb2d8ae', 'https://static.wikia.nocookie.net/dragonball/images/7/79/Jackie_Chun_vs_Krillin.png/revision/latest?cb=20150329150114&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('3320056f-b3a9-497f-98ac-661c7459a008', 'https://static.wikia.nocookie.net/dragonball/images/f/f6/Yamcha_vs_Jackie_Chun.png/revision/latest?cb=20150227160946&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('b992756a-5aa4-4e60-bd7a-9e8025bd212c', 'https://static.wikia.nocookie.net/dragonball/images/1/1f/El_Anunciador_presentando_la_pelea_entre_Bacterian_y_Krilin.png/revision/latest/scale-to-width-down/250?cb=20101111001111&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('132c07bb-e1ee-4b27-a391-71cfb145c5db', 'https://static.wikia.nocookie.net/dragonball/images/8/88/Krilin_vs_Monje.png/revision/latest?cb=20130202194813&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('eb85feac-3b7f-4d29-96ff-15fbd0c6f47e', 'https://static.wikia.nocookie.net/dragonball/images/e/ea/Nam_vs_Goku.png/revision/latest?cb=20150329233953&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('96d72bf8-ecf0-44a1-a7f6-bfed1fe1e97f', 'http://namekusei.files.wordpress.com/2010/01/round3-00053.png', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('d957574d-4553-44a5-9783-c81c7fc9b2b8', 'https://static.wikia.nocookie.net/dragonball/images/8/8e/1000px-Ep95_4.png/revision/latest?cb=20120824200046&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('c51bc64b-d1a9-4086-ad5a-f0d1953b9d44', 'https://static.wikia.nocookie.net/dragonball/images/d/db/Tao_vs_Bora.png/revision/latest?cb=20150402020851&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('0a02ea8b-e56f-4813-92a1-efd78811b3ea', 'https://static.wikia.nocookie.net/dragonball/images/f/f8/Yamcha_vs_Hombre_Invisible.png/revision/latest?cb=20150411190253&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('8e7813de-39e2-429d-a5a1-d23725ab4d85', 'https://m.media-amazon.com/images/M/MV5BYmQ0OTVlNTItYzYyMi00ZmI3LTk3ODctYjZkOGViMDkwNDRhXkEyXkFqcGdeQXVyNzgxMzc3OTc@._V1_.jpg', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('d45e8065-4d8c-4ba1-a56d-786a5c24c3fe', 'https://static.wikia.nocookie.net/dragonball/images/5/51/Goku_vs_Buyon.png/revision/latest?cb=20150302191528&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('3f7e1cc8-9c07-4078-af8a-59091e58f8b6', 'https://static.wikia.nocookie.net/dragonball/images/1/1f/Goku_vs_Black.png/revision/latest?cb=20150403170740&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('5e709d90-7285-44aa-9d1a-e2ae00bcfac3', 'https://i.ytimg.com/vi/BPdcYbJ1mm0/hqdefault.jpg', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('6c6145c2-a08c-4fd7-a745-35f46b0b5fda', 'https://static.wikia.nocookie.net/dragonball/images/7/79/Goku_vs_White.png/revision/latest?cb=20150331162141&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('ef9c502b-3ce8-46cd-92af-480ec2c13138', 'https://static.wikia.nocookie.net/dragonball/images/6/68/Goku_vs_Metallitron.png/revision/latest?cb=20150330225544&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('5af6ccd8-a0e1-4805-8453-a24799de0822', 'https://static.wikia.nocookie.net/dragonball/images/9/93/Krilin_vs_General_Blue.png/revision/latest?cb=20201207164955&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('9a0b7c13-c490-4d66-ad8c-1ef7d675c7d9', 'https://static.wikia.nocookie.net/dragonball/images/c/c2/Goku_vs_Pilaf%2C_Mai_y_Shu.png/revision/latest?cb=20150418164924&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('742c9a0b-59bd-43d8-88ba-56ec7136f0de', 'https://static.wikia.nocookie.net/dragonball/images/9/96/Goku_vs_Silver.png/revision/latest?cb=20150330021846&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('ae9745d7-7069-4bba-bb95-8758ed8dbd0e', 'https://static.wikia.nocookie.net/dragonball/images/1/11/GokuPunchBruce.png/revision/latest?cb=20130905065042&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('450ec99d-fb35-4a7b-9df0-a9a5c0f56adc', 'https://static.wikia.nocookie.net/dragonball/images/b/b2/66lr4.jpg/revision/latest/scale-to-width-down/250?cb=20131229230557&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('4c37a207-105f-4c66-a6d9-f37a577dd4d0', 'https://i.pinimg.com/736x/0a/44/d2/0a44d2191a451d5e6294caf10acac8eb--goku-vs-son-goku.jpg', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('43d466c1-20f8-4e82-86dc-0e558fdf5efc', 'https://static.wikia.nocookie.net/dragonball/images/6/64/Blue_vs_Tao_Pai_Pai.png/revision/latest?cb=20150220000147&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('af27bdb1-4d33-4ac1-a0be-b7c9f87410d7', 'https://static.wikia.nocookie.net/dragonball/images/9/94/GokuVSTao.png/revision/latest?cb=20110904214333&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('79257981-4bd8-495e-94b2-65d78d138522', 'https://static.wikia.nocookie.net/dragonball/images/e/eb/Db73-13.jpg/revision/latest/scale-to-width-down/206?cb=20131014030106&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('4a235d0d-ae0d-456a-b160-b960f9b6b5ea', 'https://static.wikia.nocookie.net/dragonball/images/2/23/Dracula_Man_vs_Krillin.png/revision/latest/scale-to-width/360?cb=20110905001738&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('8d4e2675-b7d7-4165-8c5e-a90b0f316599', 'https://static.wikia.nocookie.net/dragonball/images/b/b0/Baoya_Ten_Long_vs_Goku.png/revision/latest?cb=20140806205424&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('03bfaa77-b47d-440d-bea6-3815074dfddf', 'https://static.wikia.nocookie.net/dragonball/images/7/77/Dragon-Ball-093-Tien-Shinhan-vs.-Jackie-Chun.png/revision/latest?cb=20120831022214&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('f1f33049-0938-43d6-859e-6918e13fa35e', 'https://static.wikia.nocookie.net/dragonball/images/b/bf/Jackie_Chun_vs_Lobo_Hombre.png/revision/latest?cb=20150501171113&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('fd6d92d0-0191-457b-b0f1-9191b416d60b', 'https://static.wikia.nocookie.net/dragonball/images/9/95/Krillin_vs_Chaoz.png/revision/latest?cb=20150502145752&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('6104b9ef-96af-4b6e-9ca8-64e09ede4686', 'https://static.wikia.nocookie.net/dragonball/images/1/13/Krilin_vs_Luchador_97.png/revision/latest/top-crop/width/360/height/450?cb=20130204183415&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('43904b4b-c13e-4b91-80ca-7be6b71cdebe', 'https://static.wikia.nocookie.net/dragonball/images/c/ce/Goku_and_pamput_2.jpg/revision/latest/scale-to-width-down/250?cb=20120216185659&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('16f904e6-3635-4110-88f4-c6b0d64cc3dc', 'https://static.wikia.nocookie.net/dragonball/images/9/98/Goku_vs_el_Rey_Chappa_%28Saga_22_y_23_Torneo%29_-_Dragon_Ball_Wiki.jpg/revision/latest?cb=20160827042002&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('851fcb49-3b18-45e4-b465-2e05479c543c', 'https://m.media-amazon.com/images/M/MV5BY2IyOGQwYzUtYzFjZC00MzllLTg1ZGQtZTJkMzNjOGVmZjIyXkEyXkFqcGdeQXVyNzgxMzc3OTc@._V1_.jpg', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('65386db9-3bf9-4246-8a9f-5846a148c790', 'https://static.wikia.nocookie.net/dragonball/images/5/56/TienvsDrum.png/revision/latest?cb=20100315095007&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('5c196bb0-720d-4507-a4f4-3466a11896c6', 'https://static.wikia.nocookie.net/dragonball/images/e/ef/Yajirobe_vs_Goku.jpg/revision/latest?cb=20150126064856&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('f085e703-765f-4a11-8c08-9c77849bc42a', 'https://static.wikia.nocookie.net/dragonball/images/1/14/Tambourine_vs_Bacterian.jpg/revision/latest?cb=20100417171706&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('5b505262-3ae8-4eb8-aa2b-468f6f46acb7', 'https://static.wikia.nocookie.net/dragonball/images/2/21/Rey_Chapa_vs_Tambourine.png/revision/latest?cb=20150220190047&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('1a479695-098d-448f-97bc-13595bc66766', 'https://static.wikia.nocookie.net/universal-dragon-ball/images/c/c5/Fdgbt.jpg/revision/latest?cb=20190719164029', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('d8666f79-0a18-4aa3-8b9a-14d6141e7de9', 'https://static.wikia.nocookie.net/dragonball/images/2/2f/Goku_vs_picolo_viejo.jpg/revision/latest?cb=20140409022456&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('76316fd4-c0e9-4fe2-93ca-ec5f044f8b1a', 'https://static.wikia.nocookie.net/dragonball/images/b/bc/180px-MercenaryTaoCyborg.png/revision/latest?cb=20100621180143&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('b9638de9-6205-4167-bb3d-0a7b246764d3', 'https://cdn.hobbyconsolas.com/sites/navi.axelspringer.es/public/styles/1200/public/media/image/2019/09/krillin-vs-piccolo.jpg?itok=uaYMqqnU', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('325366ab-df52-4ced-b700-239f0aeeb143', 'https://img.wattpad.com/9680bc497c613da70e6f1bf3a68fdf878ae01982/68747470733a2f2f73332e616d617a6f6e6177732e636f6d2f776174747061642d6d656469612d736572766963652f53746f7279496d6167652f73464b49535f77346d6b303231513d3d2d31302e3136363130396630373535663533376232373338373339343734372e6a7067?s=fit&w=720&h=720', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('ab2c71b0-c32e-42ba-b746-445230aebed1', 'http://pm1.narvii.com/7223/69bb3d93964af5bae889c0113bc1e04cad121fc3r1-957-720v2_uhq.jpg', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('4199158b-ef5d-4165-b82b-41afac3073a9', 'https://static.wikia.nocookie.net/dragonball/images/b/b5/Ten_Shinhan_vs_Tao_Pai_Pai_ep136_%28DB%29_1.png/revision/latest?cb=20220217210847&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('30549442-f7a5-4679-84f2-37c66204f24f', 'https://static.wikia.nocookie.net/dragonball/images/5/5d/Anciana.jpg/revision/latest?cb=20131014050112&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('9762e874-1f45-4e80-a196-30645f96e0ca', 'https://static.wikia.nocookie.net/dragonball/images/0/03/Akkuman_Artwork.png/revision/latest/scale-to-width-down/350?cb=20160718013507&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('90610a60-234d-4d78-9022-c150b4a66903', 'https://static.wikia.nocookie.net/dragonball/images/e/e0/Hatchan.png/revision/latest/scale-to-width-down/350?cb=20140425114711&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('bf4c5052-5d63-4d4a-813a-0355047ec2b9', 'https://static.wikia.nocookie.net/dragonball/images/5/58/Anunciador_Dokkan.png/revision/latest/scale-to-width-down/350?cb=20181211235713&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('8cb3c6f2-8e71-4bf8-aff7-d5ad11f9b8f0', 'https://static.wikia.nocookie.net/dragonball/images/0/04/Arale_Artwork.png/revision/latest/scale-to-width-down/350?cb=20161101232213&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('33db35c4-82e0-409b-b50a-93fdf3f8fcde', 'https://static.wikia.nocookie.net/dragonball/images/0/03/Bacterian_Artwork.png/revision/latest/scale-to-width-down/350?cb=20160728000343&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('44f5ffe8-223e-4909-9265-20b79d616336', 'https://static.wikia.nocookie.net/dragonball/images/7/73/Fighter69.png/revision/latest/scale-to-width-down/350?cb=20130918051320&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('118905cf-0e67-4a86-abed-0e4faba74e8c', 'https://static.wikia.nocookie.net/dragonball/images/a/a1/Baoya_Ten_Long_DB.png/revision/latest/scale-to-width-down/289?cb=20171204215859&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('efc39213-0d55-4936-82d2-01b09c77bd07', 'https://static.wikia.nocookie.net/dragonball/images/4/46/Dbz13-07.jpg/revision/latest?cb=20120915051721&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('a4d93ddd-58fa-4fde-8b7d-1bb01fa104b5', 'https://static.wikia.nocookie.net/dragonball/images/b/b9/Bulma_DB_Artwork_Inicio.png/revision/latest/scale-to-width-down/350?cb=20170709213656&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('ad356060-f56b-43d1-a6c1-4b64a157cb58', 'https://static.wikia.nocookie.net/dragonball/images/f/f8/Buyon.png/revision/latest/scale-to-width-down/350?cb=20110831194417&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('4769fc27-abeb-4e1e-8659-d7a970f6584e', 'https://static.wikia.nocookie.net/dragonball/images/7/72/Capitan_Dark1.png/revision/latest?cb=20150510222059&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('43b0f06f-a541-480e-bd94-38ab37cf3364', 'https://static.wikia.nocookie.net/dragonball/images/e/ec/Chaoz2013.png/revision/latest?cb=20150812232717&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('789ac3df-c78c-43b7-ae31-f5fb418e4a9a', 'https://static.wikia.nocookie.net/dragonball/images/5/5d/Milk_DB_inicio.png/revision/latest/scale-to-width-down/350?cb=20160723132246&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('c5ec1edf-ab8a-4f93-97fa-a8966b829568', 'https://static.wikia.nocookie.net/dragonball/images/f/fa/Red_Dokkan.png/revision/latest?cb=20181208182404&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('360583f8-c942-431d-a553-9f885e0070d2', 'https://static.wikia.nocookie.net/dragonball/images/e/e3/Jefe_Conejo_Artwork.png/revision/latest/scale-to-width-down/350?cb=20170615225807&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('ecd053b5-cd70-4da4-aa78-7bec537e2a2c', 'https://static.wikia.nocookie.net/dragonball/images/0/05/General_Silver_Trans.png/revision/latest/scale-to-width-down/206?cb=20110831190853&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('1f043d2d-9c53-4efe-beb0-77ca6c8277c2', 'https://static.wikia.nocookie.net/dragonball/images/d/d1/Coronel_Violet_cara.png/revision/latest/scale-to-width-down/350?cb=20171121212052&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('6149fae0-4aec-4e2a-be5e-417ab077e0cd', 'https://static.wikia.nocookie.net/dragonball/images/a/aa/Capitan_Yellow_Trans.png/revision/latest/scale-to-width-down/350?cb=20110831191134&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('09dc530b-977b-497c-aae3-b9e3d5a4ddd8', 'https://static.wikia.nocookie.net/dragonball/images/2/2a/Oro_DB.png/revision/latest?cb=20181007204816&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('78933a31-116d-45d0-85f9-4cfeb809110b', 'https://static.wikia.nocookie.net/dragonball/images/c/cf/Plauge.p.79.png/revision/latest/scale-to-width-down/350?cb=20120930014838&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('26430b80-a749-41ca-8567-79a3d88f8a10', 'https://static.wikia.nocookie.net/dragonball/images/6/6e/Cymbal_Artwork.png/revision/latest/scale-to-width-down/350?cb=20160728000637&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('00467ed7-eed9-4bd6-a5d5-f46feb0b64fe', 'https://static.wikia.nocookie.net/dragonball/images/e/ed/SmellsLikeTrouble44.jpg/revision/latest?cb=20140423213752&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('a6baf684-2542-4a9f-b431-44621291962f', 'https://static.wikia.nocookie.net/dragonball/images/4/42/Brief_Artwork.png/revision/latest/scale-to-width-down/199?cb=20170811052304&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('ea1b1152-01cf-4c89-a755-3799ae0de224', 'https://static.wikia.nocookie.net/dragonball/images/d/d0/Dr.Flappe.png/revision/latest/scale-to-width-down/350?cb=20170205180559&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('07dde838-1043-4652-aafd-485d83c83be8', 'https://static.wikia.nocookie.net/dragonball/images/0/00/Dracula_Man_Artwork.png/revision/latest/scale-to-width-down/350?cb=20160728000840&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('006de083-6efd-4cfa-9c56-1c00a5e45009', 'https://static.wikia.nocookie.net/dragonball/images/2/2a/Drum_Artwork.png/revision/latest/scale-to-width-down/350?cb=20160728000456&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('a5347300-e37e-452d-af68-67700a79a7c6', 'https://static.wikia.nocookie.net/dragonball/images/8/86/250px-Shopkeeper1.png/revision/latest?cb=20120428183816&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('598b8678-a94c-4d0a-8c6f-536871d8fdd2', 'https://static.wikia.nocookie.net/dragonball/images/2/2d/Scout0-1-01.png/revision/latest/scale-to-width-down/350?cb=20130506060407&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('5b9f04f8-261c-4132-a073-15961f46cd40', 'https://static.wikia.nocookie.net/dragonball/images/7/7d/General_Blue_Artwork.png/revision/latest/scale-to-width-down/350?cb=20161101232511&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('abb7697b-2c24-4061-b93a-be1eab32fcdd', 'https://static.wikia.nocookie.net/dragonball/images/e/e0/White_DB.png/revision/latest/scale-to-width-down/350?cb=20171204215243&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('cd36532b-5ef0-4c4d-935b-a7fc03a7e981', 'https://static.wikia.nocookie.net/dragonball/images/e/e0/Gilan_Artwork.png/revision/latest/scale-to-width-down/350?cb=20160728000041&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('8a9a1bc0-f425-4600-8a2e-5c63acf74f71', 'https://static.wikia.nocookie.net/dragonball/images/d/d5/BruceLeeImpersonator.png/revision/latest?cb=20130906053647&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('b308838d-a776-4457-b929-fe1b05656c31', 'https://static.wikia.nocookie.net/dragonball/images/7/7d/Rey_Demonio_Piccolo_rejuvenecido_Artwork.png/revision/latest/scale-to-width-down/350?cb=20170924020119&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('3333eb48-e6ab-4283-811a-38fd62714bd5', 'https://static.wikia.nocookie.net/dragonball/images/8/83/Roshi_Pafu_Pafu_Render.png/revision/latest/scale-to-width-down/349?cb=20160610183544&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('0f19b87c-68af-43fb-a5ac-2374ce89bedb', 'http://pm1.narvii.com/6406/f7faf9ecb868f532a1cd8f3c1ea2b7c86aab26c3_00.jpg', '2a393a3f-32df-4e46-a5ec-86047bfac795')
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('5bdfc353-33fd-4759-abb4-eae3f2b8ad64', 'https://static.wikia.nocookie.net/dragonball/images/a/ac/Kami.png/revision/latest/scale-to-width-down/350?cb=20160627004416&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('800c8cbc-3da3-4805-a8ae-47e2d79b766a', 'https://static.wikia.nocookie.net/dragonball/images/1/1f/Karin_en_Super_Hero.png/revision/latest/scale-to-width-down/350?cb=20211227234812&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('b4bf562a-7015-4cc5-952c-b1195923ca17', 'https://static.wikia.nocookie.net/dragonball/images/b/b2/Krilin_DB_Artwork.png/revision/latest/scale-to-width-down/350?cb=20161216144931&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('876ab9ae-9423-425a-93cf-92973c1287a9', 'https://static.wikia.nocookie.net/dragonball/images/f/f2/Momia_Artwork.png/revision/latest/scale-to-width-down/350?cb=20160728000228&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('37664064-0df1-4ed8-83c1-7c1330995851', 'https://static.wikia.nocookie.net/dragonball/images/c/cf/Ranfan_Artwork.png/revision/latest/scale-to-width-down/350?cb=20171201162313&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('68280990-9012-4db7-bd3f-5741797b41d1', 'https://static.wikia.nocookie.net/dragonball/images/5/52/Hombrelobo.png/revision/latest/scale-to-width-down/347?cb=20110831195327&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('041031c5-2d40-401d-ad41-ae63115c0219', 'https://static.wikia.nocookie.net/dragonball/images/d/df/Lobo_final.png/revision/latest/scale-to-width-down/347?cb=20110831195416&path-prefix=es', '26da3667-8b11-4977-9785-b7744b4b8af1')
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('eff4b09d-e87d-49da-a0ba-1ff3e1936db3', 'https://static.wikia.nocookie.net/dragonball/images/6/6b/Lunch_forma_buena_Artwork.png/revision/latest/scale-to-width-down/350?cb=20161123000601&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('28063b7b-2a2c-48c0-bfc8-3b63c7b714f1', 'https://static.wikia.nocookie.net/dragonball/images/f/fb/Lunch_forma_mala_Artwork.png/revision/latest/scale-to-width-down/350?cb=20161123000624&path-prefix=es', 'b765f458-786b-4c53-a287-9a2cc28002a7')
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('77d1ca94-6d74-4af1-8585-ba8f17bc4c0b', 'https://static.wikia.nocookie.net/dragonball/images/0/0d/Mai_Dokkan.png/revision/latest?cb=20181212001631&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('244efcce-c447-49fc-bb9a-22b167d6d5b8', 'https://static.wikia.nocookie.net/dragonball/images/4/43/Mr._Popo_Artwork.png/revision/latest/scale-to-width-down/350?cb=20160803013930&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('8df3c283-05d3-4601-9d19-0729f2e51d72', 'https://static.wikia.nocookie.net/dragonball/images/1/1e/Mutaito_Artwork.png/revision/latest/scale-to-width-down/350?cb=20160713220306&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('0198c850-313c-4d5a-8e4c-3cb35672493e', 'https://static.wikia.nocookie.net/dragonball/images/b/b6/Nam4.png/revision/latest/scale-to-width-down/317?cb=20100416182842&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('dc95d149-f935-4a51-9b31-bb4baf37c30e', 'https://static.wikia.nocookie.net/dragonball/images/8/87/Pamputt_Dokkan.png/revision/latest/scale-to-width-down/350?cb=20181207211157&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('3e460819-02b8-4be0-ac46-8001bf3d25c8', 'https://static.wikia.nocookie.net/dragonball/images/9/9f/Rey_Chapa_Artwork.png/revision/latest/scale-to-width-down/350?cb=20161217082850&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('9aedd990-082f-4bbd-8aed-faad0e4993a8', 'https://static.wikia.nocookie.net/dragonball/images/3/33/Ninja_Murasaki_Artwork.png/revision/latest?cb=20200326221754&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('0300972e-d9ee-4e2d-bbe1-d5e3c6483d38', 'https://static.wikia.nocookie.net/dragonball/images/f/f9/Metallic.png/revision/latest?cb=20130128201514&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('5e786f60-9e59-4f13-85d0-cec658b79273', 'https://static.wikia.nocookie.net/dragonball/images/7/72/Shu_Dokkan.png/revision/latest?cb=20181212001421&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('083b5086-69ba-4fb0-be65-38063f3995a3', 'https://static.wikia.nocookie.net/dragonball/images/a/a3/Suno.png/revision/latest/scale-to-width-down/350?cb=20100124154002&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('e70debfe-2e40-4413-b5f6-4d350281e045', 'https://static.wikia.nocookie.net/dragonball/images/e/e0/Abuelo_Gohan_Artwork.png/revision/latest/scale-to-width-down/350?cb=20170130010549&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('549b4bfe-0e35-40ab-a900-fe4d97aef539', 'https://static.wikia.nocookie.net/dragonball/images/5/57/Goku_DB_Artwork.png/revision/latest/scale-to-width-down/350?cb=20160802220130&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('66f8fe79-a4d5-4d8a-9483-235ecf87e6f5', 'https://static.wikia.nocookie.net/dragonball/images/b/b3/Saiyajin_en_estado_Ozaru.png/revision/latest/scale-to-width-down/350?cb=20191223093312&path-prefix=es', '494b7a56-7d35-4ebc-9404-ce977ecf0aa0')
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('a7eef8ff-5e65-40d9-8a2d-e052663fde6b', 'https://static.wikia.nocookie.net/dragonball/images/d/d2/Tambourine_Oficial_Art.png/revision/latest?cb=20150901003717&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('c520ad29-e1f6-4260-8609-bb6e1ec6176a', 'https://static.wikia.nocookie.net/dragonball/images/b/b2/Tao_Pai_Pai_Artwork.png/revision/latest/scale-to-width-down/350?cb=20160718013132&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('11049b3a-bf38-4c9e-9792-8744d532c727', 'https://static.wikia.nocookie.net/dragonball/images/9/90/Cyborg_Tao_Pai_Pai_Artwork.png/revision/latest/scale-to-width-down/350?cb=20160718013205&path-prefix=es', 'f4bc3712-0141-4043-90d6-3f32d6c4b905')
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('6c690f7a-8900-4a95-8af0-1a26c18deb26', 'https://static.wikia.nocookie.net/dragonball/images/0/01/Umigame_Artwork.png/revision/latest/scale-to-width-down/350?cb=20171204214808&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('610853a5-595b-4c04-a027-d40a1bd68dd2', 'https://static.wikia.nocookie.net/dragonball/images/e/e5/Upa_ni%C3%B1o.png/revision/latest?cb=20210109154837&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('86adb326-29be-4e17-ac7d-17bbd22e9a1e', 'https://static.wikia.nocookie.net/dragonball/images/3/3e/Uranai_Baba_Artwork.png/revision/latest/scale-to-width-down/350?cb=20170114185437&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('797b27a4-09e8-449f-afc8-168d0ec57e65', 'https://static.wikia.nocookie.net/dragonball/images/1/1e/Oolong_Artwork.png/revision/latest/scale-to-width-down/350?cb=20170818005958&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('34079bf0-b512-4e15-aed4-e18ae4b443bd', 'https://static.wikia.nocookie.net/dragonball/images/9/9a/Yajirobe_Artwork.png/revision/latest/scale-to-width-down/350?cb=20170817194242&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('00eef5cc-c313-43ab-af83-588fbebb0449', 'https://static.wikia.nocookie.net/dragonball/images/1/10/Dragon_Ball_Super_Yamcha.png/revision/latest/scale-to-width-down/201?cb=20150807204201&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('8dc150e3-e29c-4737-be10-81b198c739d0', 'https://static.wikia.nocookie.net/dragonball/images/a/a4/Tenshinhan_DB_Artwork.png/revision/latest/scale-to-width-down/350?cb=20170924020116&path-prefix=es', null)
INSERT INTO imagen (ImagenId, url, PFId) VALUES ('69e4aeb9-64ae-4a3a-a0fc-c5d4e1b7b698', 'https://static.wikia.nocookie.net/dragonball/images/1/10/WMATFirstRoundsannouncer.Ep.85.png/revision/latest/scale-to-width-down/350?cb=20130918051019&path-prefix=es', null)
--Batallas
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Bulma', 'https://www.youtube.com/watch?v=n4Do1E_ndRA', '426cc89b-54fd-4082-96b4-2faa827f7ed7', 1)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Jefe Conejo', 'https://youtu.be/YPwltLT4XYE?t=56', '747db527-c618-4588-8261-8902e2a1b0d2', 1)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Yamcha vs Goku', 'https://www.youtube.com/watch?v=W2cJ2HdVMJg', 'bf2f8ed8-9bf2-4287-ba63-bcd0d64648e1', 1)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Luchador 69 del torneo', 'https://sendvid.com/embed/km813jst', 'fe1a9f5e-5086-45ca-b5a4-3bc659e6fa50', 2)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Gilan', 'https://www.youtube.com/watch?v=BIl3Iqoye7w', 'e094ca22-e6b3-49fd-a4a7-e5ce2c7066cb', 2)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Yamcha vs Ten Shinhan', 'https://www.youtube.com/watch?v=E2q33kYOxUY', 'bb5f3f6b-fc21-4f36-89c9-55c746d04c8a', 2)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Jackie Chun vs Goku', 'https://www.youtube.com/watch?v=U567_lwnCdk', '9f1e1dc5-22f7-4298-bb9a-640a3791fdda', 2)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Jackie Chun vs Krilin', 'https://www.youtube.com/watch?v=cMfILH27hpI', '61bda161-bf00-4aa0-86c4-832b3eb2d8ae', 2)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Jackie Chun vs Yamcha', 'https://www.youtube.com/watch?v=lXBPob3y_jQ', '3320056f-b3a9-497f-98ac-661c7459a008', 2)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Krilin vs Bacterian', 'https://www.youtube.com/watch?v=c3L6GYBYmCo', 'b992756a-5aa4-4e60-bd7a-9e8025bd212c', 2)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Krilin vs Monje', 'https://www.youtube.com/watch?v=cYYQdfKzGss', '132c07bb-e1ee-4b27-a391-71cfb145c5db', 2)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Nam vs Goku', 'https://www.youtube.com/watch?v=RIEKuT6h7BY', 'eb85feac-3b7f-4d29-96ff-15fbd0c6f47e', 2)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Nam vs Lan-Fan', 'https://www.youtube.com/watch?v=cFfqiUwuIjQ', '96d72bf8-ecf0-44a1-a7f6-bfed1fe1e97f', 2)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Krilin', 'https://www.youtube.com/watch?v=sw_mU6pTuo0', 'd957574d-4553-44a5-9783-c81c7fc9b2b8', 2)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Bora vs Tao Pai Pai', 'https://www.youtube.com/watch?v=K2JL-N3AsUo', 'c51bc64b-d1a9-4086-ad5a-f0d1953b9d44', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Yamcha vs El Hombre Invisible', 'https://www.youtube.com/watch?v=ebxZk4whJLg', '0a02ea8b-e56f-4813-92a1-efd78811b3ea', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs General Blue', 'https://www.youtube.com/watch?v=nAkG-0Fssns', '8e7813de-39e2-429d-a5a1-d23725ab4d85', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Buyon', 'https://www.youtube.com/watch?v=utrNDzLJcgA', 'd45e8065-4d8c-4ba1-a56d-786a5c24c3fe', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('General Black vs Goku', 'https://sendvid.com/embed/t72oent5', '3f7e1cc8-9c07-4078-af8a-59091e58f8b6', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Ninja Purpura', 'https://youtu.be/AC-Lk-nnBho?t=13', '5e709d90-7285-44aa-9d1a-e2ae00bcfac3', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs General White', 'https://www.youtube.com/watch?v=3l7bEpYCEIE', '6c6145c2-a08c-4fd7-a745-35f46b0b5fda', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Sargento Metálico', 'https://www.youtube.com/watch?v=I6J15iShN8I', '', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Maestro Roshi vs Capitán Dock', 'https://sendvid.com/embed/3b9xtol7', 'ef9c502b-3ce8-46cd-92af-480ec2c13138', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Krilin vs General Blue', 'https://www.youtube.com/watch?v=bX9X2juGGjE', '5af6ccd8-a0e1-4805-8453-a24799de0822', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Banda de Pilaf', 'https://www.youtube.com/watch?v=F_eIRCzSg54', '9a0b7c13-c490-4d66-ad8c-1ef7d675c7d9', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Coronel Silver', 'https://www.youtube.com/watch?v=yIgxEioCUX8', '742c9a0b-59bd-43d8-88ba-56ec7136f0de', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Gran Lee', 'https://www.youtube.com/watch?v=oNePUs7Y3ss', 'ae9745d7-7069-4bba-bb95-8758ed8dbd0e', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs La Momia', 'https://www.youtube.com/watch?v=Ihs64A6l-n4', '450ec99d-fb35-4a7b-9df0-a9a5c0f56adc', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Son Gohan (abuelo)', 'https://www.youtube.com/watch?v=uOtDt7oEa5Y', '4c37a207-105f-4c66-a6d9-f37a577dd4d0', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Tao Pai Pai vs General Blue', 'https://www.youtube.com/watch?v=M3d1cPDk-mg', '43d466c1-20f8-4e82-86dc-0e558fdf5efc', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Tao Pai Pai vs Goku', 'https://www.youtube.com/watch?v=KtxmHY2IwmI', 'af27bdb1-4d33-4ac1-a0be-b7c9f87410d7', 3)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Akkuman vs Goku', 'https://www.youtube.com/watch?v=rzKuC__CbUg', '79257981-4bd8-495e-94b2-65d78d138522', 4)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Dracula Man vs Krilin', 'https://www.youtube.com/watch?v=jLD5GuMRcuE', '4a235d0d-ae0d-456a-b160-b960f9b6b5ea', 4)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Baoya Tian Long', 'https://sendvid.com/embed/jfzmht5z', '8d4e2675-b7d7-4165-8c5e-a90b0f316599', 4)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Jackie Chun vs Ten Shinhan', 'https://www.youtube.com/watch?v=pBpseY6YLMA', '03bfaa77-b47d-440d-bea6-3815074dfddf', 5)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Jackie Chun vs Lobo hombre', 'https://www.youtube.com/watch?v=fA6G7zBB9BA', 'f1f33049-0938-43d6-859e-6918e13fa35e', 5)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Krilin vs Chaoz', 'https://www.youtube.com/watch?v=iPxoP3elwDM', 'fd6d92d0-0191-457b-b0f1-9191b416d60b', 5)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Krilin vs Luchador 97 del torneo', 'https://sendvid.com/embed/km813jst', '6104b9ef-96af-4b6e-9ca8-64e09ede4686', 5)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Pamputt vs Goku', 'https://www.youtube.com/watch?v=kM_cWw3cl1c', '43904b4b-c13e-4b91-80ca-7be6b71cdebe', 5)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Rey Chapa', 'https://www.youtube.com/watch?v=XLwGX4xkImc', '16f904e6-3635-4110-88f4-c6b0d64cc3dc', 5)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Ten Shinhan vs Goku', 'https://www.youtube.com/watch?v=9UQnOQMbKzk', '851fcb49-3b18-45e4-b465-2e05479c543c', 5)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Drum vs Ten Shinhan', 'https://www.youtube.com/watch?v=KwOca48vfgA', '65386db9-3bf9-4246-8a9f-5846a148c790', 6)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Yajirobe vs Goku', 'https://www.youtube.com/watch?v=RzKJEc9SjoQ', '5c196bb0-720d-4507-a4f4-3466a11896c6', 6)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Tambourine vs Bacterian', 'https://sendvid.com/embed/6167xkd0', 'f085e703-765f-4a11-8c08-9c77849bc42a', 6)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Tambourine vs Rey Chapa', 'https://www.youtube.com/watch?v=JXiYdV_AfHw', '5b505262-3ae8-4eb8-aa2b-468f6f46acb7', 6)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Tambourine vs Yamcha', 'https://www.youtube.com/watch?v=31Z1ZHDCeDY', '', 6)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Tambourine', 'https://www.youtube.com/watch?v=EvruW9VLQsw', '1a479695-098d-448f-97bc-13595bc66766', 6)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Gran Rey Demonio Piccolo vs Goku', 'https://www.youtube.com/watch?v=hXOOiMBFrF8', 'd8666f79-0a18-4aa3-8b9a-14d6141e7de9', 6)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Chaoz vs Tao Pai Pai', 'https://www.youtube.com/watch?v=XChPv6-PlQQ', '76316fd4-c0e9-4fe2-93ca-ec5f044f8b1a', 7)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Piccolo vs Krilin', 'https://www.youtube.com/watch?v=9A2OKlSLOS8', 'b9638de9-6205-4167-bb3d-0a7b246764d3', 7)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Milk', 'https://www.youtube.com/watch?v=5l84wqUBT5Q', '325366ab-df52-4ced-b700-239f0aeeb143', 7)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Goku vs Piccolo', 'https://www.youtube.com/watch?v=jDYRF86FiP0', 'ab2c71b0-c32e-42ba-b746-445230aebed1', 7)
INSERT INTO Batalla (NombreBatalla, url, ImagenId, SagaId) VALUES ('Ten Shinhan vs Tao Pai Pai', 'https://www.youtube.com/watch?v=2Q6xCA17E6M', '4199158b-ef5d-4165-b82b-41afac3073a9', 7)
--Personajes
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('aee65857-765a-45d1-9520-257b70c2a6ef', 'Abuela Baozi', 1, 22, 7, '30549442-f7a5-4679-84f2-37c66204f24f', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('2e482f1d-8115-48ab-a301-2f7ef40eafe8', 'Akkuman', 4, 6, 7, '9762e874-1f45-4e80-a196-30645f96e0ca', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('9fb56f4e-c80e-47f6-9639-e259ba2bce8e', 'Androide Número 8', 3, 1, 7, '90610a60-234d-4d78-9022-c150b4a66903', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('755417f8-8def-49a7-b25e-fd4376c840e2', 'Anunciador', 2, 22, 7, 'bf4c5052-5d63-4d4a-813a-0355047ec2b9', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('5e145ab9-fd29-43d5-8b96-f3785a104c6d', 'Arale', 3, 1, 7, '8cb3c6f2-8e71-4bf8-aff7-d5ad11f9b8f0', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('0390c252-f75e-40af-b148-65379ade6e19', 'Bacterian', 2, 22, 7, '33db35c4-82e0-409b-b50a-93fdf3f8fcde', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('4530e2c0-e968-4061-b6c1-fd6389417000', 'Luchador número 69', 2, 22, 7, '44f5ffe8-223e-4909-9265-20b79d616336', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('dedb9f6e-3ae8-4c2a-b0e0-b7369c1f382e', 'Baoya Tian Long', 4, 22, 7, '118905cf-0e67-4a86-abed-0e4faba74e8c', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('caa17149-9da7-4d09-bb67-9663dc8be16b', 'Bora', 3, 22, 7, 'efc39213-0d55-4936-82d2-01b09c77bd07', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('e19d76c6-25a9-48fe-8e41-75d80cb0c173', 'Bulma', 1, 22, 7, 'a4d93ddd-58fa-4fde-8b7d-1bb01fa104b5', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('c5150e6f-559e-4ae0-be7b-9d96f7ecf331', 'Buyon', 3, 0, 7, 'ad356060-f56b-43d1-a6c1-4b64a157cb58', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('034876a4-588f-4f85-b0ae-c8643ec0e09e', 'Capitán Dock', 3, 22, 7, '4769fc27-abeb-4e1e-8659-d7a970f6584e', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('28b1ef02-f58a-4d7f-a184-953411ee8976', 'Chaoz', 2, 4, 7, '43b0f06f-a541-480e-bd94-38ab37cf3364', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('c4ef941f-0cbd-473a-9975-163c3dd1397c', 'Milk', 1, 22, 7, '789ac3df-c78c-43b7-ae31-f5fb418e4a9a', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('a67a0523-3ceb-47be-9547-c4d39d2dd9e0', 'Comandante Red', 3, 22, 7, 'c5ec1edf-ab8a-4f93-97fa-a8966b829568', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('ab4e8fbb-6953-49f1-be96-b7357e517027', 'Conejo Zanahorizador', 1, 2, 7, '360583f8-c942-431d-a553-9f885e0070d2', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('b2cfc976-ede4-4a8b-91d8-f88b5ee76ea1', 'General Silver', 3, 22, 7, 'ecd053b5-cd70-4da4-aa78-7bec537e2a2c', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('12f6feb1-03db-41f0-966c-7f0b278dad80', 'Coronel Violet', 3, 22, 7, '1f043d2d-9c53-4efe-beb0-77ca6c8277c2', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('39fd5264-62ab-4e40-b805-bb0ca7317d88', 'Coronel Yellow', 3, 2, 7, '6149fae0-4aec-4e2a-be5e-417ab077e0cd', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('119935a6-98c2-4b1b-a6ed-0522d2f4ef39', 'Cuerno de Oro', 4, 22, 7, '09dc530b-977b-497c-aae3-b9e3d5a4ddd8', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('ec26fab9-bbf5-4cbd-8828-f36a2cbcce35', 'Cuerno de Plata', 4, 22, 7, '78933a31-116d-45d0-85f9-4cfeb809110b', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('ae32bf49-e3a0-4720-a06c-72694ac2376d', 'Cymbal', 5, 6, 7, '26430b80-a749-41ca-8567-79a3d88f8a10', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('9dac0fdb-b55a-4de2-bacf-81e638248b18', 'Dr. Brief', 3, 22, 7, 'a6baf684-2542-4a9f-b431-44621291962f', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('a68fbf16-180b-465c-a37d-b04586366e43', 'Director del Torneo de las Artes Marciales', 2, 2, 7, '00467ed7-eed9-4bd6-a5d5-f46feb0b64fe', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('e5821df2-0677-47ac-b907-a7b835c7c032', 'Dr. Frappé', 3, 22, 7, 'ea1b1152-01cf-4c89-a755-3799ae0de224', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('f43753d6-61b7-4273-828e-81b692522ffd', 'Dracula Man', 5, 26, 7, '07dde838-1043-4652-aafd-485d83c83be8', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('a5f84d23-00f5-4451-ba0d-9c9dde9d74a7', 'Drum', 6, 6, 7, '006de083-6efd-4cfa-9c56-1c00a5e45009', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('a762feb5-ad8e-4d04-abc9-3e7e97f9c202', 'Dueño de la tienda de antigüedades', 3, 22, 7, 'a5347300-e37e-452d-af68-67700a79a7c6', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('71cadda0-3db6-433b-b1f7-f6db5b039f31', 'Frank', 3, 22, 7, '598b8678-a94c-4d0a-8c6f-536871d8fdd2', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('ad97ced1-0142-4cc4-80cd-74b6d1b5372d', 'General Blue', 3, 22, 7, '5b9f04f8-261c-4132-a073-15961f46cd40', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('52af161a-375a-4e09-a18b-080f1269b413', 'General White', 3, 22, 7, 'abb7697b-2c24-4061-b93a-be1eab32fcdd', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('33097260-ddb8-4078-814a-61d2e50b8491', 'Gilan', 2, 7, 7, 'cd36532b-5ef0-4c4d-935b-a7fc03a7e981', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('6f69ce24-b653-44ba-925a-525db4423ede', 'Gran Lee', 2, 22, 7, '8a9a1bc0-f425-4600-8a2e-5c63acf74f71', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('eafd797a-a4b6-49ad-8896-ac16fd4fecce', 'Gran Rey Demonio Piccolo', 6, 19, 7, 'b308838d-a776-4457-b929-fe1b05656c31', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('0d135394-578f-4e6a-a474-f592fcadc6f5', 'Maestro Roshi', 1, 22, 7, '3333eb48-e6ab-4283-811a-38fd62714bd5', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('0c5da166-a7f5-4c75-a044-cc50da83e912', 'Kami-Sama', 6, 19, 7, '5bdfc353-33fd-4759-abb4-eae3f2b8ad64', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('f67d8621-7135-4ca9-8df2-84dcb4191ac8', 'Maestro Karin', 4, 2, 7, '800c8cbc-3da3-4805-a8ae-47e2d79b766a', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('56ff7867-2576-4efd-841a-1105c4e79021', 'Krilin', 1, 22, 7, 'b4bf562a-7015-4cc5-952c-b1195923ca17', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('8b591d72-4f44-46a0-ab52-3721c6315e62', 'La Momia', 4, 22, 7, '876ab9ae-9423-425a-93cf-92973c1287a9', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('c8ee46eb-6963-4a5e-baa5-984681780aec', 'Lan-Fan', 2, 22, 7, '37664064-0df1-4ed8-83c1-7c1330995851', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('94672494-ab24-42c6-86bf-580a75d76db1', 'Lobo Hombre', 5, 22, 7, '68280990-9012-4db7-bd3f-5741797b41d1', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('782c2329-70b4-48cd-82d9-1afd15e332df', 'Lunch', 2, 22, 7, 'eff4b09d-e87d-49da-a0ba-1ff3e1936db3', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('d24794f1-21c8-4878-9a79-e80fc5fa8a3c', 'Mai', 1, 22, 7, '77d1ca94-6d74-4af1-8585-ba8f17bc4c0b', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('7f8dca83-5602-47c1-be9a-ba44c4c4d0a0', 'Mr. Popo', 6, 11, 7, '244efcce-c447-49fc-bb9a-22b167d6d5b8', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('97fbbe81-7111-4027-acb7-0eeb36b0e927', 'Mutaito', 6, 22, 7, '8df3c283-05d3-4601-9d19-0729f2e51d72', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('68dc6863-5986-44c6-8429-9cc0cc25be73', 'Nam', 2, 22, 7, '0198c850-313c-4d5a-8e4c-3cb35672493e', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('1b8fd15e-503e-4c62-b049-dfbe23defd88', 'Pamputt', 5, 22, 7, 'dc95d149-f935-4a51-9b31-bb4baf37c30e', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('31efb7d7-2951-4866-b681-1306f02b8fdc', 'Rey Chapa', 5, 22, 7, '3e460819-02b8-4be0-ac46-8001bf3d25c8', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('2586fd82-4da0-48ff-9b46-f2ec50e302bd', 'Ninja Purpura', 3, 22, 7, '9aedd990-082f-4bbd-8aed-faad0e4993a8', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('145badec-bbba-4383-a89b-1bc0ff84cb3c', 'Sargento Metálico', 3, 1, 7, '0300972e-d9ee-4e2d-bbe1-d5e3c6483d38', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('5e786f60-9e59-4f13-85d0-cec658b79273', 'Shu', 1, 2, 7, '5e786f60-9e59-4f13-85d0-cec658b79273', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('676a035e-f805-4f0f-9bba-af8236160d96', 'Sno', 3, 1, 7, '083b5086-69ba-4fb0-be65-38063f3995a3', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('20658e6c-6a3f-4a73-a2ca-db78724e5074', 'Son Gohan (Abuelo)', 4, 22, 7, 'e70debfe-2e40-4413-b5f6-4d350281e045', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('5f413a8f-e6f4-4e45-9787-f814f6f2d7bf', 'Goku', 1, 23, 7, '549b4bfe-0e35-40ab-a900-fe4d97aef539', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('992fa3a4-281b-4c00-a9cf-00f633112c6f', 'Tambourine', 2, 6, 7, 'a7eef8ff-5e65-40d9-8a2d-e052663fde6b', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('531ab0e4-dabb-4d7e-9a44-8130a471b69d', 'Tao Pai Pai', 3, 22, 7, 'c520ad29-e1f6-4260-8609-bb6e1ec6176a', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('40597ad0-f805-49b9-9055-62f3c8b891ba', 'Tortuga Marina', 1, 2, 7, '6c690f7a-8900-4a95-8af0-1a26c18deb26', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('5a37ae4e-c8ec-4345-be1f-0a724d34f3b9', 'Upa', 3, 22, 7, '610853a5-595b-4c04-a027-d40a1bd68dd2', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('bc612a34-4b80-420e-a98b-d7581c956592', 'Uranai Baba', 4, 22, 7, '86adb326-29be-4e17-ac7d-17bbd22e9a1e', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('935282b0-8e29-4643-9e77-54f8bae174da', 'Oolong', 1, 2, 7, '797b27a4-09e8-449f-afc8-168d0ec57e65', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('eaf1c201-2e85-4c2c-b020-8c376c3f4540', 'Yajirobei', 6, 22, 7, '34079bf0-b512-4e15-aed4-e18ae4b443bd', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('65722c4b-cbb3-43b0-b4a3-d95e7b5cf1b1', 'Yamcha', 1, 22, 7, '00eef5cc-c313-43ab-af83-588fbebb0449', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('00c883d6-97d3-4e64-a4a0-68dd4388709c', 'Ten Shinhan', 5, 22, 7, '8dc150e3-e29c-4737-be10-81b198c739d0', 1)
INSERT INTO Personaje (PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('64c60a49-381c-4f4f-b331-121c14555e7b', 'Árbitro del Torneo', 2, 22, 7, '69e4aeb9-64ae-4a3a-a0fc-c5d4e1b7b698', 1)
--transformaciones
INSERT INTO PersonajesForma (PFId, PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('2a393a3f-32df-4e46-a5ec-86047bfac795', '0d135394-578f-4e6a-a474-f592fcadc6f5', 'Maestro Roshi 100% Poder', 1, 22, 7, '0f19b87c-68af-43fb-a5ac-2374ce89bedb', 1)
INSERT INTO PersonajesForma (PFId, PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('26da3667-8b11-4977-9785-b7744b4b8af1', '94672494-ab24-42c6-86bf-580a75d76db1', 'Lobo Hombre transformado', 5, 2, 7, '041031c5-2d40-401d-ad41-ae63115c0219', 1)
INSERT INTO PersonajesForma (PFId, PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('b765f458-786b-4c53-a287-9a2cc28002a7', '782c2329-70b4-48cd-82d9-1afd15e332df', 'Lunch Maldad', 2, 22, 7, '28063b7b-2a2c-48c0-bfc8-3b63c7b714f1', 1)
INSERT INTO PersonajesForma (PFId, PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('494b7a56-7d35-4ebc-9404-ce977ecf0aa0', '5f413a8f-e6f4-4e45-9787-f814f6f2d7bf', 'Goku Mono Gigantesco', 1, 23, 7, '66f8fe79-a4d5-4d8a-9483-235ecf87e6f5', 1)
INSERT INTO PersonajesForma (PFId, PersonajeId, Nombre, SagaId, RazaId, UniversoId, ImagenId, SerieId) VALUES ('f4bc3712-0141-4043-90d6-3f32d6c4b905', '531ab0e4-dabb-4d7e-9a44-8130a471b69d', 'Ciborg', 7, 1, 7, '11049b3a-bf38-4c9e-9792-8744d532c727', 1)
