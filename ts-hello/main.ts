import { LikeCount } from './LikeCount'

let likeCounter = new LikeCount(true, 100);

let likeNumber = likeCounter.setLikes(10);
let buttonOn = likeCounter.getButtonStatus();

console.log('No: of Likes: '+likeNumber+'\n'+'Button On?'+buttonOn);