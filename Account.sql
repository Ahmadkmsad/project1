CREATE DATABASE account6;
USE account6;

Create Table commentslist (
	[commentid] [int] ,
	[comment] [nvarchar](max) DEFAULT '',
	[postid] [int] ,
	Primary Key (commentid)
);

Create Table Posts (
	[PostID] [int]  NOT NULL,
	[Time] [datetime2](7) NOT NULL,
	[post] [nvarchar](max) NOT NULL,
	[voteup] [int] NOT NULL,
	[votedown] [int] NOT NULL,
	Primary Key (PostID)
);


Select * From commentslist;
Select * From Posts;

/*Task1*/
/*SELECT Posts.PostID,Posts.Time, Posts.post,Posts.voteup,Posts.votedown ,commentslist.comment FROM Posts
INNER JOIN commentslist ON commentslist.postid = Posts.PostID*/
SELECT Posts.post,Posts.voteup,Posts.votedown ,commentslist.comment FROM Posts
Left JOIN commentslist ON commentslist.postid = Posts.PostID


/*Task2*/

INSERT INTO Posts (PostID,Time,post,voteup,votedown)VALUES (1,GETDATE(),'I have not submit work',0,0);

INSERT INTO Posts (PostID,Time,post,voteup,votedown)VALUES (2,GETDATE(),'hello bro',0,0);
INSERT INTO Posts (PostID,Time,post,voteup,votedown)VALUES (3,GETDATE(),'how are you',0,0);
INSERT INTO Posts (PostID,Time,post,voteup,votedown)VALUES (4,GETDATE(),'how are you',0,0);
/*Task3*/
INSERT INTO commentslist (commentid,comment,postid)
VALUES (1,'no',1);
INSERT INTO commentslist (commentid,comment,postid)
VALUES (2,'yes',1);
INSERT INTO commentslist (commentid,comment,postid)
VALUES (3,'yes',2);
/*Task4*/
Delete From Posts
Where Posts.PostID =1;
Delete From commentslist
Where commentslist.postid = 1;
Update Posts
Set Posts.post = 'I have  submit work'
Where Posts.postID= 1 ;
/*Task5*/
Delete From commentslist
Where commentslist.commentid =1;

Update commentslist
Set commentslist.comment = 'I have  submit work'
Where  commentslist.commentid= 2 ;

/*Task6*/
Update Posts
Set Posts.voteup = Posts.voteup+1
Where  Posts.PostID= 2 ;

Update Posts
Set Posts.votedown = Posts.votedown+1
Where  Posts.PostID= 2 ;
/*Task7*/

SELECT * FROM Posts
 ORDER BY Posts.voteup DESC, Posts.Time DESC;
 /*-----------------------------------------------------------------------*/

 Select * From commentslist;
Select * From Posts;


 EXEC showposts;
 EXEC addpost  @postID=4 ,@post ='hello';
 EXEC addcomment  @postid=4  ,@commentid=5  ,@comment='haha' ;
 EXEC deletepost @postid=4 ;
 EXEC  editpost  @postid =4 ,@post='mmmm';
 EXEC deletecomment  @commentid=5;
 EXEC editcomment  @commentid = 5,@comment='lki';
 EXEC voteup @PostID=1;
 EXEC votedowns  @PostID=1;
 EXEC sorting	;