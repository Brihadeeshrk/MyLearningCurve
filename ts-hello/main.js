"use strict";
exports.__esModule = true;
var LikeCount_1 = require("./LikeCount");
var likeCounter = new LikeCount_1.LikeCount(true, 100);
var likeNumber = likeCounter.setLikes(10);
var buttonOn = likeCounter.getButtonStatus();
console.log('No: of Likes: ' + likeNumber + '\n' + 'Button On?' + buttonOn);
