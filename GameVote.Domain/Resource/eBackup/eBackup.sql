PGDMP         !                y            Vote    13.2    13.2 y    D           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            E           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            F           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            G           1262    16394    Vote    DATABASE     c   CREATE DATABASE "Vote" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "Vote";
                postgres    false            �            1259    17480 	   developer    TABLE     r   CREATE TABLE public.developer (
    id integer NOT NULL,
    name character varying(100),
    description text
);
    DROP TABLE public.developer;
       public         heap    postgres    false            �            1259    17478    developer_id_seq    SEQUENCE     �   CREATE SEQUENCE public.developer_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.developer_id_seq;
       public          postgres    false    224            H           0    0    developer_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.developer_id_seq OWNED BY public.developer.id;
          public          postgres    false    223            �            1259    17389    game    TABLE     (  CREATE TABLE public.game (
    id integer NOT NULL,
    "platformId" integer NOT NULL,
    name character varying(100),
    "genreId" integer NOT NULL,
    release date,
    "developerId" integer NOT NULL,
    "publisherId" integer NOT NULL,
    description text,
    "statusId" integer NOT NULL,
    localization boolean,
    "minAge" integer,
    "modeGame" character varying(20),
    "seriesGame" character varying(50),
    subtitle boolean,
    "typeGame" character varying,
    "urlOfficialSaitGame" character varying(100),
    "imgGame" bytea
);
    DROP TABLE public.game;
       public         heap    postgres    false            �            1259    17383    game_developerId_seq    SEQUENCE     �   CREATE SEQUENCE public."game_developerId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."game_developerId_seq";
       public          postgres    false    206            I           0    0    game_developerId_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public."game_developerId_seq" OWNED BY public.game."developerId";
          public          postgres    false    203            �            1259    17381    game_genreId_seq    SEQUENCE     �   CREATE SEQUENCE public."game_genreId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public."game_genreId_seq";
       public          postgres    false    206            J           0    0    game_genreId_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public."game_genreId_seq" OWNED BY public.game."genreId";
          public          postgres    false    202            �            1259    17377    game_id_seq    SEQUENCE     �   CREATE SEQUENCE public.game_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 "   DROP SEQUENCE public.game_id_seq;
       public          postgres    false    206            K           0    0    game_id_seq    SEQUENCE OWNED BY     ;   ALTER SEQUENCE public.game_id_seq OWNED BY public.game.id;
          public          postgres    false    200            �            1259    17379    game_platformId_seq    SEQUENCE     �   CREATE SEQUENCE public."game_platformId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."game_platformId_seq";
       public          postgres    false    206            L           0    0    game_platformId_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public."game_platformId_seq" OWNED BY public.game."platformId";
          public          postgres    false    201            �            1259    17385    game_publisherId_seq    SEQUENCE     �   CREATE SEQUENCE public."game_publisherId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."game_publisherId_seq";
       public          postgres    false    206            M           0    0    game_publisherId_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public."game_publisherId_seq" OWNED BY public.game."publisherId";
          public          postgres    false    204            �            1259    17387    game_statusId_seq    SEQUENCE     �   CREATE SEQUENCE public."game_statusId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public."game_statusId_seq";
       public          postgres    false    206            N           0    0    game_statusId_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public."game_statusId_seq" OWNED BY public.game."statusId";
          public          postgres    false    205            �            1259    17419    gamesInStore    TABLE     �   CREATE TABLE public."gamesInStore" (
    id integer NOT NULL,
    "gameId" integer NOT NULL,
    "storeId" integer NOT NULL,
    price money,
    discount integer,
    "discountedPrice" money
);
 "   DROP TABLE public."gamesInStore";
       public         heap    postgres    false            �            1259    17413    gamesInStore_gameId_seq    SEQUENCE     �   CREATE SEQUENCE public."gamesInStore_gameId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public."gamesInStore_gameId_seq";
       public          postgres    false    212            O           0    0    gamesInStore_gameId_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public."gamesInStore_gameId_seq" OWNED BY public."gamesInStore"."gameId";
          public          postgres    false    210            �            1259    17411    gamesInStore_id_seq    SEQUENCE     �   CREATE SEQUENCE public."gamesInStore_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."gamesInStore_id_seq";
       public          postgres    false    212            P           0    0    gamesInStore_id_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public."gamesInStore_id_seq" OWNED BY public."gamesInStore".id;
          public          postgres    false    209            �            1259    17415    gamesInStore_storeId_seq    SEQUENCE     �   CREATE SEQUENCE public."gamesInStore_storeId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public."gamesInStore_storeId_seq";
       public          postgres    false    212            Q           0    0    gamesInStore_storeId_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public."gamesInStore_storeId_seq" OWNED BY public."gamesInStore"."storeId";
          public          postgres    false    211            �            1259    17469    genre    TABLE     n   CREATE TABLE public.genre (
    id integer NOT NULL,
    name character varying(100),
    description text
);
    DROP TABLE public.genre;
       public         heap    postgres    false            �            1259    17467    genre_id_seq    SEQUENCE     �   CREATE SEQUENCE public.genre_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.genre_id_seq;
       public          postgres    false    222            R           0    0    genre_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.genre_id_seq OWNED BY public.genre.id;
          public          postgres    false    221            �            1259    17441    platform    TABLE     q   CREATE TABLE public.platform (
    id integer NOT NULL,
    name character varying(100),
    description text
);
    DROP TABLE public.platform;
       public         heap    postgres    false            �            1259    17439    platform_id_seq    SEQUENCE     �   CREATE SEQUENCE public.platform_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.platform_id_seq;
       public          postgres    false    216            S           0    0    platform_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.platform_id_seq OWNED BY public.platform.id;
          public          postgres    false    215            �            1259    17491 	   publisher    TABLE     r   CREATE TABLE public.publisher (
    id integer NOT NULL,
    name character varying(100),
    description text
);
    DROP TABLE public.publisher;
       public         heap    postgres    false            �            1259    17489    publisher_id_seq    SEQUENCE     �   CREATE SEQUENCE public.publisher_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.publisher_id_seq;
       public          postgres    false    226            T           0    0    publisher_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.publisher_id_seq OWNED BY public.publisher.id;
          public          postgres    false    225            �            1259    17502    status    TABLE     �   CREATE TABLE public.status (
    id integer NOT NULL,
    name character varying(100),
    description character varying(300)
);
    DROP TABLE public.status;
       public         heap    postgres    false            �            1259    17500    status_id_seq    SEQUENCE     �   CREATE SEQUENCE public.status_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.status_id_seq;
       public          postgres    false    228            U           0    0    status_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.status_id_seq OWNED BY public.status.id;
          public          postgres    false    227            �            1259    17405    store    TABLE     h   CREATE TABLE public.store (
    id integer NOT NULL,
    name character(100),
    description "char"
);
    DROP TABLE public.store;
       public         heap    postgres    false            �            1259    17403    store_id_seq    SEQUENCE     �   CREATE SEQUENCE public.store_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.store_id_seq;
       public          postgres    false    208            V           0    0    store_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.store_id_seq OWNED BY public.store.id;
          public          postgres    false    207            �            1259    17430    user    TABLE     �   CREATE TABLE public."user" (
    id integer NOT NULL,
    name character varying(200),
    email character varying(200),
    phone character varying(11),
    login character varying(200),
    password character varying(60)
);
    DROP TABLE public."user";
       public         heap    postgres    false            �            1259    17428    user_id_seq    SEQUENCE     �   CREATE SEQUENCE public.user_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 "   DROP SEQUENCE public.user_id_seq;
       public          postgres    false    214            W           0    0    user_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.user_id_seq OWNED BY public."user".id;
          public          postgres    false    213            �            1259    17458    vote    TABLE     �   CREATE TABLE public.vote (
    id integer NOT NULL,
    "gameId" integer NOT NULL,
    "storeId" integer NOT NULL,
    date date,
    price money
);
    DROP TABLE public.vote;
       public         heap    postgres    false            �            1259    17452    vote_gameId_seq    SEQUENCE     �   CREATE SEQUENCE public."vote_gameId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public."vote_gameId_seq";
       public          postgres    false    220            X           0    0    vote_gameId_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public."vote_gameId_seq" OWNED BY public.vote."gameId";
          public          postgres    false    218            �            1259    17450    vote_id_seq    SEQUENCE     �   CREATE SEQUENCE public.vote_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 "   DROP SEQUENCE public.vote_id_seq;
       public          postgres    false    220            Y           0    0    vote_id_seq    SEQUENCE OWNED BY     ;   ALTER SEQUENCE public.vote_id_seq OWNED BY public.vote.id;
          public          postgres    false    217            �            1259    17456    vote_storeId_seq    SEQUENCE     �   CREATE SEQUENCE public."vote_storeId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public."vote_storeId_seq";
       public          postgres    false    220            Z           0    0    vote_storeId_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public."vote_storeId_seq" OWNED BY public.vote."storeId";
          public          postgres    false    219            �           2604    17483    developer id    DEFAULT     l   ALTER TABLE ONLY public.developer ALTER COLUMN id SET DEFAULT nextval('public.developer_id_seq'::regclass);
 ;   ALTER TABLE public.developer ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    223    224    224            p           2604    17392    game id    DEFAULT     b   ALTER TABLE ONLY public.game ALTER COLUMN id SET DEFAULT nextval('public.game_id_seq'::regclass);
 6   ALTER TABLE public.game ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    206    200    206            q           2604    17393    game platformId    DEFAULT     v   ALTER TABLE ONLY public.game ALTER COLUMN "platformId" SET DEFAULT nextval('public."game_platformId_seq"'::regclass);
 @   ALTER TABLE public.game ALTER COLUMN "platformId" DROP DEFAULT;
       public          postgres    false    201    206    206            r           2604    17394    game genreId    DEFAULT     p   ALTER TABLE ONLY public.game ALTER COLUMN "genreId" SET DEFAULT nextval('public."game_genreId_seq"'::regclass);
 =   ALTER TABLE public.game ALTER COLUMN "genreId" DROP DEFAULT;
       public          postgres    false    206    202    206            s           2604    17395    game developerId    DEFAULT     x   ALTER TABLE ONLY public.game ALTER COLUMN "developerId" SET DEFAULT nextval('public."game_developerId_seq"'::regclass);
 A   ALTER TABLE public.game ALTER COLUMN "developerId" DROP DEFAULT;
       public          postgres    false    206    203    206            t           2604    17396    game publisherId    DEFAULT     x   ALTER TABLE ONLY public.game ALTER COLUMN "publisherId" SET DEFAULT nextval('public."game_publisherId_seq"'::regclass);
 A   ALTER TABLE public.game ALTER COLUMN "publisherId" DROP DEFAULT;
       public          postgres    false    204    206    206            u           2604    17397    game statusId    DEFAULT     r   ALTER TABLE ONLY public.game ALTER COLUMN "statusId" SET DEFAULT nextval('public."game_statusId_seq"'::regclass);
 >   ALTER TABLE public.game ALTER COLUMN "statusId" DROP DEFAULT;
       public          postgres    false    206    205    206            w           2604    17422    gamesInStore id    DEFAULT     v   ALTER TABLE ONLY public."gamesInStore" ALTER COLUMN id SET DEFAULT nextval('public."gamesInStore_id_seq"'::regclass);
 @   ALTER TABLE public."gamesInStore" ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    209    212    212            x           2604    17423    gamesInStore gameId    DEFAULT     �   ALTER TABLE ONLY public."gamesInStore" ALTER COLUMN "gameId" SET DEFAULT nextval('public."gamesInStore_gameId_seq"'::regclass);
 F   ALTER TABLE public."gamesInStore" ALTER COLUMN "gameId" DROP DEFAULT;
       public          postgres    false    212    210    212            y           2604    17424    gamesInStore storeId    DEFAULT     �   ALTER TABLE ONLY public."gamesInStore" ALTER COLUMN "storeId" SET DEFAULT nextval('public."gamesInStore_storeId_seq"'::regclass);
 G   ALTER TABLE public."gamesInStore" ALTER COLUMN "storeId" DROP DEFAULT;
       public          postgres    false    212    211    212                       2604    17472    genre id    DEFAULT     d   ALTER TABLE ONLY public.genre ALTER COLUMN id SET DEFAULT nextval('public.genre_id_seq'::regclass);
 7   ALTER TABLE public.genre ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    221    222    222            {           2604    17444    platform id    DEFAULT     j   ALTER TABLE ONLY public.platform ALTER COLUMN id SET DEFAULT nextval('public.platform_id_seq'::regclass);
 :   ALTER TABLE public.platform ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    215    216    216            �           2604    17494    publisher id    DEFAULT     l   ALTER TABLE ONLY public.publisher ALTER COLUMN id SET DEFAULT nextval('public.publisher_id_seq'::regclass);
 ;   ALTER TABLE public.publisher ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    225    226    226            �           2604    17505 	   status id    DEFAULT     f   ALTER TABLE ONLY public.status ALTER COLUMN id SET DEFAULT nextval('public.status_id_seq'::regclass);
 8   ALTER TABLE public.status ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    227    228    228            v           2604    17408    store id    DEFAULT     d   ALTER TABLE ONLY public.store ALTER COLUMN id SET DEFAULT nextval('public.store_id_seq'::regclass);
 7   ALTER TABLE public.store ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    208    207    208            z           2604    17433    user id    DEFAULT     d   ALTER TABLE ONLY public."user" ALTER COLUMN id SET DEFAULT nextval('public.user_id_seq'::regclass);
 8   ALTER TABLE public."user" ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    214    213    214            |           2604    17461    vote id    DEFAULT     b   ALTER TABLE ONLY public.vote ALTER COLUMN id SET DEFAULT nextval('public.vote_id_seq'::regclass);
 6   ALTER TABLE public.vote ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    220    217    220            }           2604    17462    vote gameId    DEFAULT     n   ALTER TABLE ONLY public.vote ALTER COLUMN "gameId" SET DEFAULT nextval('public."vote_gameId_seq"'::regclass);
 <   ALTER TABLE public.vote ALTER COLUMN "gameId" DROP DEFAULT;
       public          postgres    false    218    220    220            ~           2604    17464    vote storeId    DEFAULT     p   ALTER TABLE ONLY public.vote ALTER COLUMN "storeId" SET DEFAULT nextval('public."vote_storeId_seq"'::regclass);
 =   ALTER TABLE public.vote ALTER COLUMN "storeId" DROP DEFAULT;
       public          postgres    false    220    219    220            =          0    17480 	   developer 
   TABLE DATA           :   COPY public.developer (id, name, description) FROM stdin;
    public          postgres    false    224   1�       +          0    17389    game 
   TABLE DATA           �   COPY public.game (id, "platformId", name, "genreId", release, "developerId", "publisherId", description, "statusId", localization, "minAge", "modeGame", "seriesGame", subtitle, "typeGame", "urlOfficialSaitGame", "imgGame") FROM stdin;
    public          postgres    false    206   o�       1          0    17419    gamesInStore 
   TABLE DATA           e   COPY public."gamesInStore" (id, "gameId", "storeId", price, discount, "discountedPrice") FROM stdin;
    public          postgres    false    212   ��       ;          0    17469    genre 
   TABLE DATA           6   COPY public.genre (id, name, description) FROM stdin;
    public          postgres    false    222   ׆       5          0    17441    platform 
   TABLE DATA           9   COPY public.platform (id, name, description) FROM stdin;
    public          postgres    false    216   �       ?          0    17491 	   publisher 
   TABLE DATA           :   COPY public.publisher (id, name, description) FROM stdin;
    public          postgres    false    226   4�       A          0    17502    status 
   TABLE DATA           7   COPY public.status (id, name, description) FROM stdin;
    public          postgres    false    228   o�       -          0    17405    store 
   TABLE DATA           6   COPY public.store (id, name, description) FROM stdin;
    public          postgres    false    208   ��       3          0    17430    user 
   TABLE DATA           I   COPY public."user" (id, name, email, phone, login, password) FROM stdin;
    public          postgres    false    214   ��       9          0    17458    vote 
   TABLE DATA           D   COPY public.vote (id, "gameId", "storeId", date, price) FROM stdin;
    public          postgres    false    220   ڇ       [           0    0    developer_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.developer_id_seq', 2, true);
          public          postgres    false    223            \           0    0    game_developerId_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."game_developerId_seq"', 1, false);
          public          postgres    false    203            ]           0    0    game_genreId_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."game_genreId_seq"', 1, false);
          public          postgres    false    202            ^           0    0    game_id_seq    SEQUENCE SET     9   SELECT pg_catalog.setval('public.game_id_seq', 5, true);
          public          postgres    false    200            _           0    0    game_platformId_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."game_platformId_seq"', 1, false);
          public          postgres    false    201            `           0    0    game_publisherId_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."game_publisherId_seq"', 1, false);
          public          postgres    false    204            a           0    0    game_statusId_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."game_statusId_seq"', 3, true);
          public          postgres    false    205            b           0    0    gamesInStore_gameId_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."gamesInStore_gameId_seq"', 1, false);
          public          postgres    false    210            c           0    0    gamesInStore_id_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."gamesInStore_id_seq"', 1, false);
          public          postgres    false    209            d           0    0    gamesInStore_storeId_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public."gamesInStore_storeId_seq"', 1, false);
          public          postgres    false    211            e           0    0    genre_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.genre_id_seq', 1, true);
          public          postgres    false    221            f           0    0    platform_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.platform_id_seq', 1, true);
          public          postgres    false    215            g           0    0    publisher_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.publisher_id_seq', 2, true);
          public          postgres    false    225            h           0    0    status_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.status_id_seq', 1, true);
          public          postgres    false    227            i           0    0    store_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.store_id_seq', 1, false);
          public          postgres    false    207            j           0    0    user_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.user_id_seq', 1, false);
          public          postgres    false    213            k           0    0    vote_gameId_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."vote_gameId_seq"', 1, false);
          public          postgres    false    218            l           0    0    vote_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.vote_id_seq', 1, false);
          public          postgres    false    217            m           0    0    vote_storeId_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."vote_storeId_seq"', 1, false);
          public          postgres    false    219            �           2606    17488    developer developer_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.developer
    ADD CONSTRAINT developer_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.developer DROP CONSTRAINT developer_pkey;
       public            postgres    false    224            �           2606    17402    game game_pkey 
   CONSTRAINT     L   ALTER TABLE ONLY public.game
    ADD CONSTRAINT game_pkey PRIMARY KEY (id);
 8   ALTER TABLE ONLY public.game DROP CONSTRAINT game_pkey;
       public            postgres    false    206            �           2606    17427    gamesInStore gamesInStore_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public."gamesInStore"
    ADD CONSTRAINT "gamesInStore_pkey" PRIMARY KEY (id);
 L   ALTER TABLE ONLY public."gamesInStore" DROP CONSTRAINT "gamesInStore_pkey";
       public            postgres    false    212            �           2606    17477    genre genre_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.genre
    ADD CONSTRAINT genre_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.genre DROP CONSTRAINT genre_pkey;
       public            postgres    false    222            �           2606    17570 &   game name_platform_developer_publisher 
   CONSTRAINT     �   ALTER TABLE ONLY public.game
    ADD CONSTRAINT name_platform_developer_publisher UNIQUE (name, "platformId", "developerId", "publisherId");
 P   ALTER TABLE ONLY public.game DROP CONSTRAINT name_platform_developer_publisher;
       public            postgres    false    206    206    206    206            �           2606    17449    platform platform_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.platform
    ADD CONSTRAINT platform_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.platform DROP CONSTRAINT platform_pkey;
       public            postgres    false    216            �           2606    17499    publisher publisher_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.publisher
    ADD CONSTRAINT publisher_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.publisher DROP CONSTRAINT publisher_pkey;
       public            postgres    false    226            �           2606    17507    status status_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.status
    ADD CONSTRAINT status_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.status DROP CONSTRAINT status_pkey;
       public            postgres    false    228            �           2606    17410    store store_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.store
    ADD CONSTRAINT store_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.store DROP CONSTRAINT store_pkey;
       public            postgres    false    208            �           2606    17438    user user_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public."user"
    ADD CONSTRAINT user_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public."user" DROP CONSTRAINT user_pkey;
       public            postgres    false    214            �           2606    17466    vote vote_pkey 
   CONSTRAINT     L   ALTER TABLE ONLY public.vote
    ADD CONSTRAINT vote_pkey PRIMARY KEY (id);
 8   ALTER TABLE ONLY public.vote DROP CONSTRAINT vote_pkey;
       public            postgres    false    220            �           2606    17538    game game_developerId_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.game
    ADD CONSTRAINT "game_developerId_fkey" FOREIGN KEY ("developerId") REFERENCES public.developer(id) NOT VALID;
 F   ALTER TABLE ONLY public.game DROP CONSTRAINT "game_developerId_fkey";
       public          postgres    false    2964    224    206            �           2606    17553    game game_genreId_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.game
    ADD CONSTRAINT "game_genreId_fkey" FOREIGN KEY ("genreId") REFERENCES public.genre(id) NOT VALID;
 B   ALTER TABLE ONLY public.game DROP CONSTRAINT "game_genreId_fkey";
       public          postgres    false    222    2962    206            �           2606    17508    game game_platformId_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.game
    ADD CONSTRAINT "game_platformId_fkey" FOREIGN KEY ("platformId") REFERENCES public.platform(id) NOT VALID;
 E   ALTER TABLE ONLY public.game DROP CONSTRAINT "game_platformId_fkey";
       public          postgres    false    206    216    2958            �           2606    17543    game game_publisherId_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.game
    ADD CONSTRAINT "game_publisherId_fkey" FOREIGN KEY ("publisherId") REFERENCES public.publisher(id) NOT VALID;
 F   ALTER TABLE ONLY public.game DROP CONSTRAINT "game_publisherId_fkey";
       public          postgres    false    2966    226    206            �           2606    17575    game game_status    FK CONSTRAINT     }   ALTER TABLE ONLY public.game
    ADD CONSTRAINT game_status FOREIGN KEY ("statusId") REFERENCES public.status(id) NOT VALID;
 :   ALTER TABLE ONLY public.game DROP CONSTRAINT game_status;
       public          postgres    false    2968    228    206            �           2606    17558 %   gamesInStore gamesInStore_gameId_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."gamesInStore"
    ADD CONSTRAINT "gamesInStore_gameId_fkey" FOREIGN KEY ("gameId") REFERENCES public.game(id) NOT VALID;
 S   ALTER TABLE ONLY public."gamesInStore" DROP CONSTRAINT "gamesInStore_gameId_fkey";
       public          postgres    false    2948    206    212            �           2606    17563 &   gamesInStore gamesInStore_storeId_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."gamesInStore"
    ADD CONSTRAINT "gamesInStore_storeId_fkey" FOREIGN KEY ("storeId") REFERENCES public.store(id) NOT VALID;
 T   ALTER TABLE ONLY public."gamesInStore" DROP CONSTRAINT "gamesInStore_storeId_fkey";
       public          postgres    false    2952    212    208            �           2606    17523    vote vote_gameId_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.vote
    ADD CONSTRAINT "vote_gameId_fkey" FOREIGN KEY ("gameId") REFERENCES public.game(id) NOT VALID;
 A   ALTER TABLE ONLY public.vote DROP CONSTRAINT "vote_gameId_fkey";
       public          postgres    false    206    2948    220            �           2606    17518    vote vote_id_fkey    FK CONSTRAINT     v   ALTER TABLE ONLY public.vote
    ADD CONSTRAINT vote_id_fkey FOREIGN KEY (id) REFERENCES public."user"(id) NOT VALID;
 ;   ALTER TABLE ONLY public.vote DROP CONSTRAINT vote_id_fkey;
       public          postgres    false    214    220    2956            �           2606    17533    vote vote_storeId_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.vote
    ADD CONSTRAINT "vote_storeId_fkey" FOREIGN KEY ("storeId") REFERENCES public.store(id) NOT VALID;
 B   ALTER TABLE ONLY public.vote DROP CONSTRAINT "vote_storeId_fkey";
       public          postgres    false    220    2952    208            =   .   x�3��paÅ�`r�}�.�_�qa�!g��I#�d� �
"�      +   ;   x�3�4估���6�F����@�	�1~P�D�".S$�FuF@�WO� ��M      1      x������ � �      ;      x�3估�{/6r��q��qqq e�      5       x�3估����.켰���?�=... �;
�      ?   +   x�3估���[.l��ta��{9c���0��@�1z\\\ ��      A   !   x�3��x���M�/6r��q��qqq ��	�      -      x������ � �      3      x������ � �      9      x������ � �     