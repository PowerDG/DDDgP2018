/*
Navicat MySQL Data Transfer

Source Server         : research_home
Source Server Version : 80015
Source Host           : 192.168.1.102:3306
Source Database       : research_home

Target Server Type    : MYSQL
Target Server Version : 80015
File Encoding         : 65001

Date: 2019-06-17 16:45:11
*/

SET FOREIGN_KEY_CHECKS=0;

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
) ENGINE=InnoDB AUTO_INCREMENT=127 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin ROW_FORMAT=DYNAMIC;
