#!/usr/bin/python3

import os
import sys
from PyQt5.QtWidgets import (QVBoxLayout, QHBoxLayout, QLabel, QMainWindow, QWidget, QToolTip, QPushButton, QApplication)
from PyQt5.QtGui import (QImage, QPixmap, QFont)
from PyQt5.QtCore import (QObject, pyqtSignal, pyqtSlot, QThread)

from PyQt5.uic import loadUi

import PyQt5.QtCore

import cv2

from functools import partial

class OCV_Class(QThread):
    """OCV_Class is for the opencv part of the interface"""

    changePixmap = pyqtSignal(QPixmap)
    btn_name = '---'

    def __init__(self, device_id=0, parent=None):
        QThread.__init__(self, parent)
        self.videocap = cv2.VideoCapture(device_id)

    def run(self):
        while True:
            ret, frame = self.videocap.read()

            # Operaions
            if self.btn_name == 'Grey':
                frame = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
            else:
                frame = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)

            qt_img = self.convert_to_qtformat(frame)
            self.changePixmap.emit(qt_img)

    def convert_to_qtformat(self, frame):
        # rgb_image = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
        rgb_image = frame
        convertToQtFormat = QImage(rgb_image.data, rgb_image.shape[1], rgb_image.shape[0], QImage.Format_RGB888)
        convertToQtFormat = QPixmap.fromImage(convertToQtFormat)
        p = convertToQtFormat.scaled(640, 480, PyQt5.QtCore.Qt.KeepAspectRatio)
        return p

    def set_btn_name(self, btn_name):
        self.btn_name = btn_name

        

class PQTInterface(QWidget):
    """docstring for PQTInterface"""

    def __init__(self):
        super(PQTInterface, self).__init__()
        self.initUI()

    def initUI(self):

        self.ocv = OCV_Class()
        # self.thread = QThread()

        self.video_placeholder = QLabel(self)

        start_btn = QPushButton('Start', self)
        start_btn.clicked.connect(partial(self.button_clicked, start_btn))

        grey_btn = QPushButton('Grey', self)
        grey_btn.clicked.connect(partial(self.button_clicked, grey_btn))

        gauss_filter_btn = QPushButton('Gauss Filter', self)
        gauss_filter_btn.clicked.connect(partial(self.button_clicked, gauss_filter_btn))

        = QPushButton('', self)
        .clicked.connect(partial(self.button_clicked, ))

        = QPushButton('', self)
        .clicked.connect(partial(self.button_clicked, ))

        = QPushButton('', self)
        .clicked.connect(partial(self.button_clicked, ))

        = QPushButton('', self)
        .clicked.connect(partial(self.button_clicked, ))

        = QPushButton('', self)
        .clicked.connect(partial(self.button_clicked, ))

        = QPushButton('', self)
        .clicked.connect(partial(self.button_clicked, ))

        = QPushButton('', self)
        .clicked.connect(partial(self.button_clicked, ))

        = QPushButton('', self)
        .clicked.connect(partial(self.button_clicked, ))

        = QPushButton('', self)
        .clicked.connect(partial(self.button_clicked, ))

        # Filters buttons
        left_v_layout = QVBoxLayout()

        # Other buttons
        right_v_layout = QVBoxLayout()
        right_v_layout.addWidget(start_btn)
        right_v_layout.addWidget(grey_btn)

        # layout for gathering all the top layouts and video_placeholder
        top_h_layout = QHBoxLayout()
        top_h_layout.addWidget(self.video_placeholder)

        # Object tracking and detection buttons
        bottom_h_layout = QHBoxLayout()

        page_layout = QVBoxLayout()
        page_layout.addWidget(top_h_layout)
        page_layout.addWidget(bottom_h_layout)

        # Setting the page_layout as the main layout
        self.setLayout(page_layout)
        self.setGeometry(20, 150, 500, 500)
        self.setWindowTitle('simple window')
        self.show()

    # function for emitting the button_value signal
    def button_clicked(self, button):
        self.ocv.set_btn_name(button.text())
        self._start_video_play()

    def _start_video_play(self):
        self.ocv.changePixmap.connect(self.video_placeholder.setPixmap)
        self.ocv.start()

































if __name__ == '__main__':

    # Every PyQt5 application must create an application object
    app = QApplication(sys.argv)

    ui = PQTInterface()


    sys.exit(app.exec_())