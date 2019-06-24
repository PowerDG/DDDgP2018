/*
Navicat MySQL Data Transfer

Source Server         : research_home
Source Server Version : 80015
Source Host           : 192.168.1.102:3306
Source Database       : research_home

Target Server Type    : MYSQL
Target Server Version : 80015
File Encoding         : 65001

Date: 2019-06-24 14:35:11
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for annualintegrals
-- ----------------------------
DROP TABLE IF EXISTS `annualintegrals`;
CREATE TABLE `annualintegrals` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `MemberId` int(11) NOT NULL,
  `Years` int(11) NOT NULL,
  `AnnualIntegral` int(11) NOT NULL,
  `UpdatedTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for appraisals
-- ----------------------------
DROP TABLE IF EXISTS `appraisals`;
CREATE TABLE `appraisals` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Year` int(4) NOT NULL,
  `Type` varchar(4) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `ValueScore` decimal(5,2) DEFAULT NULL,
  `PerformanceScore` decimal(5,2) DEFAULT NULL,
  `Level` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL COMMENT '四个等级',
  `MemberId` int(11) NOT NULL,
  `CreatedMemberId` int(11) NOT NULL,
  `CreatedTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `TotalScore` decimal(5,2) DEFAULT NULL,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for book
-- ----------------------------
DROP TABLE IF EXISTS `book`;
CREATE TABLE `book` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Author` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Photo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `PhotoHD` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `MemberId` int(11) DEFAULT NULL,
  `average_score` int(11) NOT NULL DEFAULT '0',
  `resource` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `state` tinyint(1) unsigned NOT NULL DEFAULT '0' COMMENT '0可借，1已借，2丢失',
  `last_comment` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `create_time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for book_comment
-- ----------------------------
DROP TABLE IF EXISTS `book_comment`;
CREATE TABLE `book_comment` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `create_time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `book_id` int(11) NOT NULL,
  `member_id` int(255) NOT NULL,
  `comment` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `score` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=77 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for contribution_standard
-- ----------------------------
DROP TABLE IF EXISTS `contribution_standard`;
CREATE TABLE `contribution_standard` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ParentId` int(11) NOT NULL,
  `Name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Level` int(11) NOT NULL,
  `CreatedTime` datetime NOT NULL,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=71 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for feedbacks
-- ----------------------------
DROP TABLE IF EXISTS `feedbacks`;
CREATE TABLE `feedbacks` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Content` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `MemberId` int(11) DEFAULT NULL,
  `ProviderId` int(11) DEFAULT NULL,
  `CreatedTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `ProviderName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=118 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for fund
-- ----------------------------
DROP TABLE IF EXISTS `fund`;
CREATE TABLE `fund` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ItemName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `InsertTime` datetime DEFAULT NULL,
  `Description` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `OperatMoney` decimal(15,2) DEFAULT NULL,
  `RemainMoney` decimal(15,2) DEFAULT '0.00',
  `MemberId` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=218 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for gifts
-- ----------------------------
DROP TABLE IF EXISTS `gifts`;
CREATE TABLE `gifts` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Price` decimal(10,2) DEFAULT NULL,
  `Hyperlink` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `MemberId` int(11) NOT NULL,
  `CreatedTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `CreatedMemberId` int(11) NOT NULL,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for integrals
-- ----------------------------
DROP TABLE IF EXISTS `integrals`;
CREATE TABLE `integrals` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `MemberId` int(11) DEFAULT NULL,
  `CreatedTime` datetime DEFAULT NULL,
  `Integral` int(11) DEFAULT NULL,
  `Description` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin,
  `SourceId` int(11) DEFAULT NULL,
  `SourceType` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=117 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for introductions
-- ----------------------------
DROP TABLE IF EXISTS `introductions`;
CREATE TABLE `introductions` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `Content` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin,
  `Type` int(11) DEFAULT NULL COMMENT '1.介绍',
  `CreateUser` int(11) DEFAULT NULL,
  `UpdateUser` int(11) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UpdateTime` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE,
  KEY `article_ibfk_1` (`CreateUser`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for keyresults
-- ----------------------------
DROP TABLE IF EXISTS `keyresults`;
CREATE TABLE `keyresults` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Description` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `LastUpdateMemberId` int(11) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `Status` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL COMMENT '开放，关闭',
  `ClosedMemberId` int(11) DEFAULT NULL,
  `ClosedTime` datetime DEFAULT NULL,
  `Remark` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin COMMENT '备注',
  `LastUpdateTime` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `TaskId` int(11) DEFAULT NULL,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for likerecords
-- ----------------------------
DROP TABLE IF EXISTS `likerecords`;
CREATE TABLE `likerecords` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `MemberId` int(11) NOT NULL,
  `LikeMeMemberId` int(11) NOT NULL,
  `LastOperateTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `OperateType` int(11) NOT NULL DEFAULT '0' COMMENT '点赞=1，加油=2，取消=0',
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for medals
-- ----------------------------
DROP TABLE IF EXISTS `medals`;
CREATE TABLE `medals` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Icon` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL DEFAULT '1',
  `Name` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Description` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Count` int(11) NOT NULL DEFAULT '0',
  `IsDiscard` bit(1) NOT NULL DEFAULT b'0',
  `CreatedTime` datetime DEFAULT NULL,
  `DiscardTime` datetime DEFAULT NULL,
  `Grade` int(11) NOT NULL,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for memberlabels
-- ----------------------------
DROP TABLE IF EXISTS `memberlabels`;
CREATE TABLE `memberlabels` (
  `Id` int(20) NOT NULL AUTO_INCREMENT,
  `MemberId` int(20) NOT NULL,
  `Label` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Count` int(20) NOT NULL,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for membermedals
-- ----------------------------
DROP TABLE IF EXISTS `membermedals`;
CREATE TABLE `membermedals` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `MemberId` int(11) NOT NULL,
  `MedalId` int(11) NOT NULL,
  `Reason` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `GainDate` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `TaskId` int(11) DEFAULT NULL COMMENT '哪个任务中获取此勋章',
  `GainType` int(11) DEFAULT NULL COMMENT '1=组内，2=外援',
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=169 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

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

-- ----------------------------
-- Table structure for memberskills
-- ----------------------------
DROP TABLE IF EXISTS `memberskills`;
CREATE TABLE `memberskills` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SkillId` int(11) NOT NULL,
  `MemberId` int(11) NOT NULL,
  `GainDate` date NOT NULL,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=260 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for members_test
-- ----------------------------
DROP TABLE IF EXISTS `members_test`;
CREATE TABLE `members_test` (
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
) ENGINE=InnoDB AUTO_INCREMENT=203 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for parties
-- ----------------------------
DROP TABLE IF EXISTS `parties`;
CREATE TABLE `parties` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `MemberId` int(11) DEFAULT '0',
  `StartTime` datetime DEFAULT NULL,
  `EndTime` datetime DEFAULT NULL,
  `Address` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `Tel` varchar(22) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `PartyName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `PartyPlace` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `Money` decimal(11,2) DEFAULT NULL,
  `MoneyResource` int(3) DEFAULT NULL,
  `Number` int(10) DEFAULT NULL,
  `LikeLevel` int(2) DEFAULT NULL,
  `ReviewTimes` int(11) DEFAULT '0',
  `Longitude` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `Latitude` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=109 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for partiesreviews
-- ----------------------------
DROP TABLE IF EXISTS `partiesreviews`;
CREATE TABLE `partiesreviews` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `PartyId` int(11) DEFAULT NULL,
  `MemberId` int(11) DEFAULT NULL,
  `Review` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `ReviewTime` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=136 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for partyphotos
-- ----------------------------
DROP TABLE IF EXISTS `partyphotos`;
CREATE TABLE `partyphotos` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `PartyId` int(11) DEFAULT NULL,
  `ImgUrl` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `ImgUrlPart` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `ImgDescription` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=65 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for pictures
-- ----------------------------
DROP TABLE IF EXISTS `pictures`;
CREATE TABLE `pictures` (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `Url` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `PartialPictureUrl` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `Description` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `MemberId` int(11) DEFAULT NULL,
  `UpdatedTime` datetime DEFAULT NULL,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=98 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for plans
-- ----------------------------
DROP TABLE IF EXISTS `plans`;
CREATE TABLE `plans` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `CreatedMemberId` int(11) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `Status` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL COMMENT '开放，关闭',
  `ClosedTime` datetime DEFAULT NULL,
  `Remark` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin COMMENT '备注',
  `LastUpdateTime` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for skills
-- ----------------------------
DROP TABLE IF EXISTS `skills`;
CREATE TABLE `skills` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ParentId` int(11) NOT NULL,
  `Name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Level` int(11) NOT NULL,
  `CreatedTime` datetime NOT NULL,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=100 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for taskcommunicationreplys
-- ----------------------------
DROP TABLE IF EXISTS `taskcommunicationreplys`;
CREATE TABLE `taskcommunicationreplys` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `CommunicationId` int(11) NOT NULL,
  `MemberId` int(11) NOT NULL,
  `Content` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin,
  `ReplyMemberId` int(11) DEFAULT NULL,
  `CreatedTime` datetime DEFAULT NULL,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for taskcommunications
-- ----------------------------
DROP TABLE IF EXISTS `taskcommunications`;
CREATE TABLE `taskcommunications` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `TaskId` int(11) NOT NULL,
  `Content` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin,
  `MemberId` int(11) DEFAULT NULL,
  `CreatedTime` datetime DEFAULT NULL,
  `Type` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for taskpartners
-- ----------------------------
DROP TABLE IF EXISTS `taskpartners`;
CREATE TABLE `taskpartners` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `MemberId` int(11) DEFAULT NULL,
  `TaskId` int(11) DEFAULT NULL,
  `Description` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin,
  `CreatedTime` datetime DEFAULT NULL,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for taskreviews
-- ----------------------------
DROP TABLE IF EXISTS `taskreviews`;
CREATE TABLE `taskreviews` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `TaskId` int(11) NOT NULL,
  `PerfectFunction` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `TroubleFunction` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `StrongAspect` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `WeaknessAspect` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=104 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for tasks
-- ----------------------------
DROP TABLE IF EXISTS `tasks`;
CREATE TABLE `tasks` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `Score` int(11) DEFAULT NULL,
  `Status` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `MemberId` int(11) DEFAULT NULL,
  `StartTime` datetime DEFAULT NULL,
  `EndTime` datetime DEFAULT NULL,
  `DeadLineTime` datetime DEFAULT NULL,
  `Description` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin COMMENT '说明',
  `CreatedMemberId` int(11) DEFAULT NULL,
  `CreatedTime` datetime DEFAULT NULL,
  `ScoreApportioned` bit(1) DEFAULT b'0',
  `LastUpdateTime` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `PlanId` int(11) DEFAULT NULL COMMENT 'NULL表示短期任务',
  `Priority` int(11) NOT NULL DEFAULT '3',
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=114 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for tasktrackings
-- ----------------------------
DROP TABLE IF EXISTS `tasktrackings`;
CREATE TABLE `tasktrackings` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `FollowerId` int(11) DEFAULT NULL,
  `TaskId` int(11) DEFAULT NULL,
  `FollowTime` datetime DEFAULT NULL,
  `FollowDescription` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin,
  `FollowType` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=1230 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for task_feedback
-- ----------------------------
DROP TABLE IF EXISTS `task_feedback`;
CREATE TABLE `task_feedback` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `task_id` int(11) NOT NULL,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `member_id` int(11) DEFAULT NULL,
  `type` tinyint(1) unsigned DEFAULT '0' COMMENT '1亮点2窝心3点赞4加油',
  `description` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=74 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for titlechanges
-- ----------------------------
DROP TABLE IF EXISTS `titlechanges`;
CREATE TABLE `titlechanges` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `MemberId` int(11) NOT NULL,
  `OldTitle` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `NewTitle` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `ChangedTime` datetime NOT NULL,
  `CreatedMemberId` int(11) NOT NULL,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for todos
-- ----------------------------
DROP TABLE IF EXISTS `todos`;
CREATE TABLE `todos` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Description` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `CreateMemberId` int(11) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `Status` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL COMMENT '未完成，执行中，完成',
  `Executor` int(11) DEFAULT NULL,
  `ClosedTime` datetime DEFAULT NULL,
  `Remark` text CHARACTER SET utf8mb4 COLLATE utf8mb4_bin COMMENT '备注',
  `LastUpdateTime` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `TaskId` int(11) DEFAULT NULL,
  `modified_time` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=423 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;
