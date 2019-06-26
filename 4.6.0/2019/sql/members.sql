/*
Navicat MySQL Data Transfer

Source Server         : research_home
Source Server Version : 80015
Source Host           : 192.168.1.102:3306
Source Database       : research_home

Target Server Type    : MYSQL
Target Server Version : 80015
File Encoding         : 65001

Date: 2019-06-17 16:42:15
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for members
-- ----------------------------
DROP TABLE IF EXISTS `members`;
CREATE TABLE `members` (
  `Id` int(20) NOT NULL AUTO_INCREMENT,
  `Account` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Password` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `PasswordKey` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Photo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `PhotoHD` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `art_photo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `Gender` bit(1) NOT NULL,
  `Phone` varchar(22) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT '0',
  `QQ` varchar(22) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT '0',
  `WeChat` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `EntryTime` date NOT NULL,
  `Email` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `Title` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `BirthDay` date DEFAULT NULL,
  `Remarks` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin,
  `IsAdmin` bit(1) NOT NULL DEFAULT b'0',
  `TotalIntegral` int(11) NOT NULL DEFAULT '0' COMMENT '总积分',
  `LikeCount` int(11) NOT NULL DEFAULT '0' COMMENT '点赞',
  `DislikeCount` int(11) NOT NULL DEFAULT '0' COMMENT '加油(鼓励)',
  `LeaveTime` date DEFAULT NULL,
  `IsLeave` bit(1) NOT NULL DEFAULT b'0',
  `AliasName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `Motto` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=204 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;
