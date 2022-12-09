Create Procedure showposts
	
As
BEGIN;
SELECT Posts.post,Posts.voteup,Posts.votedown ,commentslist.comment FROM Posts
Left JOIN commentslist ON commentslist.postid = Posts.PostID
END;

Create Procedure addpost
	(@postID int ,@post varchar(max))
As
BEGIN;

INSERT INTO Posts (PostID,Time,post,voteup,votedown)VALUES (@postID,GETDATE(),@post,0,0);
END;

Create Procedure addcomment
	(@postid int ,@commentid int ,@comment varchar(max))
As
BEGIN;
INSERT INTO commentslist (commentid,comment,postid)
VALUES (@commentid,@comment,@postid);
END;


Create Procedure deletepost
	(@postid int )
As
BEGIN;
Delete From Posts
Where Posts.PostID =@postid;
Delete From commentslist
Where commentslist.postid = @postid;
END;

Create Procedure editpost
	(@postid int ,@post varchar(max))
As
BEGIN;
Update Posts
Set Posts.post =@post
Where Posts.postID=@postid ;
END;

Create Procedure deletecomment
	(@commentid int )
As
BEGIN;
Delete From commentslist
Where commentslist.commentid =@commentid;

END;

Create Procedure editcomment
	(@commentid int ,@comment varchar(max))
As
BEGIN;
Update commentslist
Set commentslist.comment =@comment
Where  commentslist.commentid= @commentid;
END;


Create Procedure voteup
	(@PostID int )
As
BEGIN;
Update Posts
Set Posts.voteup = Posts.voteup+1
Where  Posts.PostID= @PostID ;
END;


Create Procedure votedowns
	(@PostID int )
As
BEGIN;
Update Posts
Set Posts.votedown = Posts.votedown+1
Where  Posts.PostID= @PostID ;
END;



Create Procedure sorting	
	
As
BEGIN;
SELECT * FROM Posts
 ORDER BY Posts.voteup DESC, Posts.Time DESC
END;
