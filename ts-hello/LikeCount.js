"use strict";
exports.__esModule = true;
exports.LikeCount = void 0;
var LikeCount = /** @class */ (function () {
    function LikeCount(buttonStatus, likes) {
        this.buttonStatus = buttonStatus;
        this.likes = likes;
    }
    LikeCount.prototype.getButtonStatus = function () {
        return this.buttonStatus;
    };
    LikeCount.prototype.getLikes = function () {
        return this.likes;
    };
    LikeCount.prototype.setLikes = function (value) {
        if (value <= 0)
            throw new Error('Value cannot be 0 or equal to 0');
        else
            this.likes = value;
    };
    return LikeCount;
}());
exports.LikeCount = LikeCount;
