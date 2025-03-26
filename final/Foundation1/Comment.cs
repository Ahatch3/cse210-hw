


public class Comment
{

    private string _commenter;

    private string _comment;


    public Comment(string _commenter, string _comment){

        this._comment = _comment;
        this._commenter = _commenter;

    }

    public void CommentDisplay(){

        Console.WriteLine($"\n~~{_commenter} says:\n--{_comment}");

    }

}