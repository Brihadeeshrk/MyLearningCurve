export class LikeCount{
    private buttonStatus: boolean;
    private likes: number;

    constructor(buttonStatus: boolean, likes: number){
        this.buttonStatus = buttonStatus;
        this.likes = likes;
    }

    getButtonStatus(){
        return this.buttonStatus;
    }

    getLikes(){
        return this.likes;
    }

    setLikes(value){
        if(value <= 0)
            throw new Error('Value cannot be 0 or equal to 0');
        else
            this.likes = value;
    }
}